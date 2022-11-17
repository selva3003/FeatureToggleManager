namespace Fmr.NovaUI.NovaTemplates;
public sealed class FilledDataTemplateFactory : NovaDataTemplateFactory
{
    public override NovaDataType Type => NovaDataType.Filled;

    protected override DataTemplate CreateDataTemplateCore(string propertyName,string formatString = null)
    {
        return new DataTemplate(() =>
        {
            Label label = new ()
            {
                VerticalOptions = LayoutOptions.Center;
                VerticalOptions = LayoutOptions.Start;
            };
        label.SetBinding(Label.TextProperty, propertyName, stringFormat: formatString);
        label.SetBinding(Label.TextColorProperty,propertyName,converter: new FilledColorConverter())
        });
    }
}