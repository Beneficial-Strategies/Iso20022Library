// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction has an origin and a destination in the same country and is made in the currency of that country.
/// </summary>
[IsoId("_SZgzFdp-Ed-ak6NoX_4Aeg_74971843")]
[DisplayName("Credit Line")]
public partial record CreditLine1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the credit line is included or not.||Usage: if not present, credit line is not included in the balance amount.
    /// </summary>
    [IsoId("_SZgzFtp-Ed-ak6NoX_4Aeg_160859924")]
    [DisplayName("Included")]
    [IsoXmlTag("Incl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Included { get; init; } 
    
    /// <summary>
    /// Amount of money of the credit line.
    /// </summary>
    [IsoId("_SZgzF9p-Ed-ak6NoX_4Aeg_490554747")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CurrencyAndAmount? Amount { get; init; } 
    
    
    #nullable disable
    
}
