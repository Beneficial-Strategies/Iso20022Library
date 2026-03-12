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
[IsoId("_SpKYqdp-Ed-ak6NoX_4Aeg_1141917187")]
[DisplayName("Adjustment")]
public partial record Adjustment4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code.
    /// </summary>
    [IsoId("_SpKYqtp-Ed-ak6NoX_4Aeg_1141917204")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdjustmentType2Code Type { get; init; } 
    
    /// <summary>
    /// Specifies a type of adjustment not present in the code list.
    /// </summary>
    [IsoId("_SpKYq9p-Ed-ak6NoX_4Aeg_1141917222")]
    [DisplayName("Other Adjustment Type")]
    [IsoXmlTag("OthrAdjstmntTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OtherAdjustmentType { get; init; } 
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_SpKYrNp-Ed-ak6NoX_4Aeg_1141917239")]
    [DisplayName("Direction")]
    [IsoXmlTag("Drctn")]
    public required AdjustmentDirection1Code Direction { get; init; } 
    
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    [IsoId("_SpKYrdp-Ed-ak6NoX_4Aeg_1141917257")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
