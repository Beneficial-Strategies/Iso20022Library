// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains electronic commerce data. 
/// </summary>
[IsoId("_NJD5E2zZEemD24gVaMSpeA")]
[DisplayName("E Commerce Data")]
public partial record ECommerceData1
{
    #nullable enable
    
    /// <summary>
    /// Type of the ecommerce data (for example ,ECI level, downgrade reason, etc).
    /// </summary>
    [IsoId("_NJD5FWzZEemD24gVaMSpeA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Value related to a specific ecommerce type.
    /// </summary>
    [IsoId("_NJD5FGzZEemD24gVaMSpeA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public required IsoMax2048Text Value { get; init; } 
    
    
    #nullable disable
    
}
