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
[IsoId("_yPMT8bQBEee1Ke-6rZgsrA")]
[DisplayName("Price")]
public partial record Price7
{
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_yehJYbQBEee1Ke-6rZgsrA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required YieldedOrValueType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_yehJY7QBEee1Ke-6rZgsrA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmount3Choice_ Value { get; init; } 
    
    
    #nullable disable
    
}
