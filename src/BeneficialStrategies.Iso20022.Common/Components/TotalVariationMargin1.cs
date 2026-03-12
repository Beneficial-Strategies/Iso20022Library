// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
/// </summary>
[IsoId("_Uk2CNNp-Ed-ak6NoX_4Aeg_-526751507")]
[DisplayName("Total Variation Margin")]
public partial record TotalVariationMargin1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the variation margin position is short or long, that is, wether the balance is a negative or positive balance.
    /// </summary>
    [IsoId("_Uk2CNdp-Ed-ak6NoX_4Aeg_-1149405445")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public ShortLong1Code? ShortLongIndicator { get; init; } 
    
    /// <summary>
    /// Provides the variation margin amount in the reporting currency and optionally in the original currency.
    /// </summary>
    [IsoId("_Uk2CNtp-Ed-ak6NoX_4Aeg_464053575")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public required Amount2 AmountDetails { get; init; } 
    
    
    #nullable disable
    
}
