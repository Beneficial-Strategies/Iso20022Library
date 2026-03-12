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
[IsoId("_2b4TgGjLEeSHBr6v3XO0Mg")]
[DisplayName("Customer Device")]
public partial record CustomerDevice1
{
    #nullable enable
    
    /// <summary>
    /// Identifier of the component.
    /// </summary>
    [IsoId("_-c-cIGjLEeSHBr6v3XO0Mg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Type of component.
    /// </summary>
    [IsoId("_AEInMGjMEeSHBr6v3XO0Mg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Provider of the component.
    /// </summary>
    [IsoId("_BDADMGjMEeSHBr6v3XO0Mg")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; } 
    
    
    #nullable disable
    
}
