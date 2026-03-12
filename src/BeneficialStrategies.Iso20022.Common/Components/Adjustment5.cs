// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
[IsoId("_SpUJrtp-Ed-ak6NoX_4Aeg_-1123474716")]
[DisplayName("Adjustment")]
public partial record Adjustment5
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the adjustment must be substracted or added to the total amount.
    /// </summary>
    [IsoId("_SpdTkNp-Ed-ak6NoX_4Aeg_-1123474593")]
    [DisplayName("Direction")]
    [IsoXmlTag("Drctn")]
    public required AdjustmentDirection1Code Direction { get; init; } 
    
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    [IsoId("_SpdTkdp-Ed-ak6NoX_4Aeg_-1123474532")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
