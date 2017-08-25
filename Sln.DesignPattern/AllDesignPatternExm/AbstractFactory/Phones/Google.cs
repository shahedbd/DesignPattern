namespace AllDesignPatternExm.AbstractFactory.Phones
{
    class Google : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new GooglePixelXL();
        }

        public INormalPhone GetNormalPhone()
        {
            return new GoogleNexus5X();
        }
    }
}
