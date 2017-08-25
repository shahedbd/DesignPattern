namespace AllDesignPatternExm.AbstractFactory.Phones
{
    class GoogleNexus5X : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Google Nexus 5X\nRAM: Normal\nCamera: Poor quality\n";
        }
    }
}
