namespace AllDesignPatternExm.AbstractFactory
{
    interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
