// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the value and optionaly the type of price.
/// </summary>
[IsoId("_QeScgNp-Ed-ak6NoX_4Aeg_2016277432")]
[DisplayName("Price")]
public partial record Price4
{
    #nullable enable
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QeScgdp-Ed-ak6NoX_4Aeg_-1069713425")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountChoice_ Value { get; init; } 
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_QeScgtp-Ed-ak6NoX_4Aeg_61095194")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PriceValueType7Code? Type { get; init; } 
    
    
    #nullable disable
    
}
