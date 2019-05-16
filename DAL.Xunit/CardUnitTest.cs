using System;
using System.Collections.Generic;
using Persistence;
using Xunit;
namespace DAL.Xunit
{
    public class CardUnitTest
    {
        private CardDAL cardDAL = new CardDAL();
        [Fact]
        public void CreateCardTest1()
        {
            string card_id = "CM20";
            string cus_id = "122332386";
            string cus_name = "Lê Chí Dũng";
            string cus_address = "Bắc Giang";
            string cus_licensePlate = "89-B5-8888";
            string cardTime = "16/5/2019 - 16/6/2019";
            string cardType = "Thẻ tháng";
            Card_Detail card_Detail = new Card_Detail(card_id, cus_id, cardTime,null);
            Card card = new Card(card_id, cus_licensePlate, cardType, null, null, null);
            Customer cus = new Customer(cus_id, cus_name, cus_address, cus_licensePlate);
            Assert.True(cardDAL.CreateCard(card, cus, card_Detail));
        }
        [Fact]
        public void CreateCardTest2()
        {
            string card_id = "CM20";
            string cus_id = "122332386";
            string cus_name = "Lê Chí Dũng";
            string cus_address = "Bắc Giang";
            string cus_licensePlate = "89-B5-8888";
            string cardTime = "16/5/2019 - 16/6/2019";
            string cardType = "Thẻ tháng";
            Card_Detail card_Detail = new Card_Detail(card_id, cus_id, cardTime,null);
            Card card = new Card(card_id, cus_licensePlate, cardType, null, null, null);
            Customer cus = new Customer(cus_id, cus_name, cus_address, cus_licensePlate);
            Assert.False(cardDAL.CreateCard(card, cus, card_Detail));
        }

    }
}