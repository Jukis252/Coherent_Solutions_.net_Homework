namespace Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class TrackingProperty : Attribute
    {
        public string? PropertyName { get; set; }

    }
}
