// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type and information about a price.
/// </summary>
[IsoId("_wKmy5yAZEeu4a6pNulzZ4Q")]
[DisplayName("Price")]
public partial record Price11
{
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_wKnZQSAZEeu4a6pNulzZ4Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required YieldedOrValueType2Choice_ Type { get; init; } 
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_wKnZQyAZEeu4a6pNulzZ4Q")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmount1Choice_ Value { get; init; } 
    
    
    #nullable disable
    
}
