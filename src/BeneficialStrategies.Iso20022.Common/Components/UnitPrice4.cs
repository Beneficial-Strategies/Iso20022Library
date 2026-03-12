// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_U4glFNp-Ed-ak6NoX_4Aeg_-1557165466")]
[DisplayName("Unit Price")]
public partial record UnitPrice4
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4glFdp-Ed-ak6NoX_4Aeg_-1484209806")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice8Code Type { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4glFtp-Ed-ak6NoX_4Aeg_-1484209805")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    
    #nullable disable
    
}
