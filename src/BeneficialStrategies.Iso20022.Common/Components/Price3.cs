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
[IsoId("_WimvZNp-Ed-ak6NoX_4Aeg_1241581910")]
[DisplayName("Price")]
public partial record Price3
{
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_WimvZdp-Ed-ak6NoX_4Aeg_-1813914755")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required YieldedOrValueType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_WimvZtp-Ed-ak6NoX_4Aeg_373068769")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmount1Choice_ Value { get; init; } 
    
    
    #nullable disable
    
}
