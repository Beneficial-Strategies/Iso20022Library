// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// GenericInformation exchanged with a name and value.
/// </summary>
[IsoId("_b4INoNwJEeeKpa-yxjuKzQ")]
[DisplayName("Generic Information")]
public partial record GenericInformation1
{
    #nullable enable
    
    /// <summary>
    /// Name of the generic information to exchange.
    /// </summary>
    [IsoId("_toLu4NwJEeeKpa-yxjuKzQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; } 
    
    /// <summary>
    /// Value of the generic information to exchange.
    /// </summary>
    [IsoId("_Em5tYNwKEeeKpa-yxjuKzQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Value { get; init; } 
    
    
    #nullable disable
    
}
