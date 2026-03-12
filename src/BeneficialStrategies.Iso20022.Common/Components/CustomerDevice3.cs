// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device used by the customer to perform the payment.
/// </summary>
[IsoId("_RIHVgS5GEeunNvJlR_vCbg")]
[DisplayName("Customer Device")]
public partial record CustomerDevice3
{
    #nullable enable
    
    /// <summary>
    /// Identifier of the component.
    /// </summary>
    [IsoId("_RWgW0S5GEeunNvJlR_vCbg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Type of component.
    /// </summary>
    [IsoId("_RWgW0y5GEeunNvJlR_vCbg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Type { get; init; } 
    
    /// <summary>
    /// Provider of the component.
    /// </summary>
    [IsoId("_RWgW1S5GEeunNvJlR_vCbg")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; } 
    
    
    #nullable disable
    
}
