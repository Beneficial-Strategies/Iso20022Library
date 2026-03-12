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
[IsoId("_SpUJotp-Ed-ak6NoX_4Aeg_912882684")]
[DisplayName("Adjustment")]
public partial record Adjustment3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code.
    /// </summary>
    [IsoId("_SpUJo9p-Ed-ak6NoX_4Aeg_912882709")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdjustmentType2Code Type { get; init; } 
    
    /// <summary>
    /// Specifies a type of adjustment not present in the code list.
    /// </summary>
    [IsoId("_SpUJpNp-Ed-ak6NoX_4Aeg_912882726")]
    [DisplayName("Other Adjustment Type")]
    [IsoXmlTag("OthrAdjstmntTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OtherAdjustmentType { get; init; } 
    
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    [IsoId("_SpUJpdp-Ed-ak6NoX_4Aeg_912882986")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Specifies the percentage rate of the adjustment.
    /// </summary>
    [IsoId("_SpUJptp-Ed-ak6NoX_4Aeg_912883021")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_SpUJp9p-Ed-ak6NoX_4Aeg_912882744")]
    [DisplayName("Direction")]
    [IsoXmlTag("Drctn")]
    public required AdjustmentDirection1Code Direction { get; init; } 
    
    
    #nullable disable
    
}
