using Caching.RedisWorker;
using Entities.ViewModels;
using Entities.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;
using Utilities.Contants;

namespace WEB.UI.FilterAttribute
{
    public class KeywordBlackList : ActionFilterAttribute
    {
        public string[] product_params { get; set; }
        private readonly RedisConn redisService;
        private readonly IConfiguration Configuration;
        public KeywordBlackList(string[] _product_params, RedisConn _redisService, IConfiguration _Configuration)
        {
            product_params = _product_params;
            redisService = _redisService;
            Configuration = _Configuration;
        }
        public async override void OnActionExecuting(ActionExecutingContext context)
        {
            bool IsAjaxRequest = context.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            string product_code = string.Empty;
            string label_name = string.Empty;
            int db_index = 1;
            int db_index_blacklist = Convert.ToInt32(Configuration["Redis:Database:db_common"]);
            if (context.ActionArguments.ContainsKey("product_code"))
            {
                product_code = context.ActionArguments["product_code"].ToString();
                // Check blacklist 
                var j_blacklist_data = await redisService.GetAsync(CacheType.KEYWORD_BLACK_LIST, db_index_blacklist);
                var lst = JsonConvert.DeserializeObject<List<ProductBlackList>>(j_blacklist_data);
                if (lst.FirstOrDefault(x => x.keywords.ToUpper() == product_code.ToUpper() && x.keyword_type == KeywordType.product_code ) != null)
                {
                    if (IsAjaxRequest)
                    {
                        
                    }
                    else
                    {
                      //  context.Result = new RedirectResult(signInPageUrl); 
                    }
                }
            }

            if (context.ActionArguments.ContainsKey("label_name"))
            {
                label_name = context.ActionArguments["label_name"].ToString();
            }

            if (!string.IsNullOrEmpty(product_code))
            {
                // get data product by cache
                int label_id = LabelNameType.GetLabelId(label_name.Trim());
                string cache_key = CacheHelper.cacheKeyProductDetail(product_code.ToString(), label_id);
                switch (label_id)
                {
                    case (Int16)LabelType.amazon:
                        db_index = Convert.ToInt32(Configuration["Redis:Database:db_product_amazon"]);
                        break;

                }
                var j_product_detail = await redisService.GetAsync(cache_key, db_index);
                if (!string.IsNullOrEmpty(j_product_detail) && j_product_detail != "null")
                {
                    // Đọc từ Redis 
                    var product_detail = JsonConvert.DeserializeObject<ProductViewModel>(j_product_detail);
                    //check by product_code

                    // check by product_name

                }
            }

            //if (IsAjaxRequest)
            //{


            //    if (!string.IsNullOrEmpty(product_code))
            //    {
            //        var jsonResult = new JsonResult(new { status = true, msg = "" });
            //        context.Result = jsonResult;
            //    }
            //}
            //else
            //{
            //    context.Result = new RedirectResult(signInPageUrl);
            //}
        }

    }
}
