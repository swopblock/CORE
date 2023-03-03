namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void TestBTCUnit()
        {
            var unit = new BTC();

            Assert.Equal(unit.Text, "BTC");
        }

        [Fact]
        public void TestETHUnit()
        {
            var unit = new ETH();

            Assert.Equal(unit.Text, "ETH");
        }

        [Fact]
        public void TestUSDUnit()
        {
            var unit = new USD();

            Assert.Equal(unit.Text, "USD");
        }

        [Fact]
        public void TestSWOBLUnit() 
        { 
            var unit = new SWOBL();

            Assert.Equal(unit.Text, "SWOBL");
        }

        [Fact]
        public void TestSWOBLOrder()
        {
            var unit = new SWOBL();

            var order = new Order(unit);

            Assert.Equal("SWOBL using the market.", order.Text);
        }

        [Fact]
        public void TestAmount()
        {
            var amount = new Amount(1000);

            Assert.Equal("1000", amount.Text);
        }

        [Fact]
        public void TestAddress() 
        {
            var address = new Address("0xFB");

            Assert.Equal("0xFB", address.Text);

        }

        [Fact]
        public void TestOffer()
        {
            var amount = new Amount(123);

            var offerUnit = new SWOBL();

            var usingUnit = new BTC();

            var usingAddress = new Address("0x2947");

            var offer = new Offer(amount, offerUnit, usingUnit, usingAddress);

            Assert.Equal(" 123", amount.Text);

            Assert.Equal(" SWOBL", offerUnit.Text);

            Assert.Equal(" BTC", usingUnit.Text);

            Assert.Equal(" address 0x2947", usingAddress.Text);

            Assert.Equal(" 123 SWOBL using the BTC address 0x2947", offer.Text);
        }
    }
}