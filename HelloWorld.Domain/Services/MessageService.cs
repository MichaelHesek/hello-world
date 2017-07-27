using HelloWorld.Domain.Models;
using System;

namespace HelloWorld.Domain.Services
{
    public class MessageService :BaseService, IMessageService
    {
        /// <summary>
        /// Returns Hello World Message
        /// </summary>
        /// <returns></returns>
        public IMessage GetMessage()
        {
            IMessage messageModel = ModelManager.Message;
            messageModel.Value = "Hello World";

            return messageModel;
        }
    }
}
