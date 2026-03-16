namespace BeneficialStrategies.Iso20022.Metadata;

/// <summary>
/// Sets the ISO id number for the decorated item. May be used for resource lookup.
/// </summary>
public class IsoIdAttribute : Attribute
{
    /// <summary>
    /// Decorates the corresponding property with the given ISO id.
    /// </summary>
    /// <param name="id">Id number</param>
    public IsoIdAttribute(string id)
    {
        Id = id;
    }

    /// <summary>
    /// The official identifier assigned to this item by the ISO 20022 working group.
    /// </summary>
    public string Id { get; }
}
