namespace fmr.NovaUI.Converters;
 public sealed class OrderTypeDataTemplateFactory : NovaDataTemplateFactory
{
    public override NovaDataType Type => NovaDataType.OrderType;

    protected override DataTemplate CreateDataTemplateCore(string propertyName, string formatString = null)
    {
        return new DataTemplate(() =>
        {
            Label label = new ()
            {
                VerticalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Start;
        };
        label.SetBinding(Label.TextProperty, propertyName, converter: new FilledColorConverter());
    });
    }
}

