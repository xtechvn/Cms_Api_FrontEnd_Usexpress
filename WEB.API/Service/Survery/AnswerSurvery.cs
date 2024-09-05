using Entities.ViewModels.ServicePublic;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.API.Service.Survery
{
    public class AnswerSurvery
    {
        private readonly IConfiguration configuration;
        //Code khai báo một biến cấp classs của IMongoCollection<Carts>.Interface IMongoCollection biểu diễn một MongoDB collection.
        private IMongoCollection<AnswerSurveryViewModel> AnswerSurveryCollection;
        public AnswerSurvery(IConfiguration _Configuration)
        {
            configuration = _Configuration;

            var client = new MongoClient("mongodb://" + configuration["DataBaseConfig:MongoServer:Host"] + "");
            IMongoDatabase db = client.GetDatabase(configuration["DataBaseConfig:MongoServer:catalog"]);
            this.AnswerSurveryCollection = db.GetCollection<AnswerSurveryViewModel>("AnswerSurvery");

        }
        public async Task<AnswerSurveryViewModel> addNew(AnswerSurveryViewModel answerSurvery)
        {
            try
            {
                await AnswerSurveryCollection.InsertOneAsync(answerSurvery);
                return answerSurvery;
            }
            catch (Exception ex)
            {
                Utilities.LogHelper.InsertLogTelegram("addNew - AnswerSurvery: " + ex);
                return null;
            }
        }
    }
}
