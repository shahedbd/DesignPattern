namespace AllDesignPatternExm.AbstractFactory.Phones
{
    class GooglePixelXL : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Google Pixel XL\nRAM: 4GB\nCamera: 12MP\n";
        }
    }
}
