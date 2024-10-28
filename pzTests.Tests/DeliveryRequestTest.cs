using Delivery;
using Xunit;

namespace pzTests.Tests
{
    public class DeliveryRequestTest
    {
        [Fact]
        public void DeliveryRequest_DefaultConstructor_SetDefaultValues()
        {
            var request = new DeliveryRequest();

            Assert.Equal(0, request.ID);
            Assert.Equal(0, request.Summ);
            Assert.Equal("Неизвестно", request.Adr);
            Assert.Equal(new DateTime(1, 1, 1), request.RequestTime);
        }
        
        [Fact]
        public void DeliveryRequest_GetCountRequest_ReturnCorrectCount()
        {
            int initialCount = DeliveryRequest.GetCountRequest();
            var request1 = new DeliveryRequest(1, 100, "Address1");
            var request2 = new DeliveryRequest(2, 200, "Address2");

            int currentCount = DeliveryRequest.GetCountRequest();

            Assert.Equal(initialCount + 2, currentCount);
        }
        
        [Fact]
        public void DeliveryRequest_GetAllSumm_ReturnCorrectSum()
        {
            int initialSum = DeliveryRequest.GetAllSumm();
            var request1 = new DeliveryRequest(1, 100, "Address1");
            var request2 = new DeliveryRequest(2, 200, "Address2");

            int currentSum = DeliveryRequest.GetAllSumm();

            Assert.Equal(initialSum + 300, currentSum);
        }
    }
}