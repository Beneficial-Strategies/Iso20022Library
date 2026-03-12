// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_mBzOifJqEeiJn9rM2Znz2w")]
[DisplayName("Adjustment")]
public partial record Adjustment9
{
    #nullable enable
    
    /// <summary>
    /// Type of adjustment.
    /// </summary>
    [IsoId("_mBzOjvJqEeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Additional information to specify the type of adjustment.
    /// </summary>
    [IsoId("_mBzOi_JqEeiJn9rM2Znz2w")]
    [DisplayName("Additional Type")]
    [IsoXmlTag("AddtlTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalType { get; init; } 
    
    /// <summary>
    /// Description of the adjustment.
    /// </summary>
    [IsoId("_mBzOivJqEeiJn9rM2Znz2w")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Description { get; init; } 
    
    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    [IsoId("_mBzOj_JqEeiJn9rM2Znz2w")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    /// <summary>
    /// Promotion or adjustment code.
    /// </summary>
    [IsoId("_sn8w4Rs4EeqrvK3udMUsNQ")]
    [DisplayName("Promotion Code")]
    [IsoXmlTag("PrmtnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PromotionCode { get; init; } 
    
    /// <summary>
    /// Contains the percentage value of the discount (when applicable).
    /// </summary>
    [IsoId("_mBzOkPJqEeiJn9rM2Znz2w")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Percentage { get; init; } 
    
    /// <summary>
    /// Contains amount of the adjustment, exclusive of tax.
    /// </summary>
    [IsoId("_mBzOjfJqEeiJn9rM2Znz2w")]
    [DisplayName("Adjustment Amount")]
    [IsoXmlTag("AdjstmntAmt")]
    public ImpliedCurrencyAndAmount? AdjustmentAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether or not tax was calculated on the original amount of the transaction. 
    /// Note that false (or not present) indicates applicable taxes are based on adjusted amount.
    /// </summary>
    [IsoId("_mBzOkfJqEeiJn9rM2Znz2w")]
    [DisplayName("Tax Calculated On Original Amount")]
    [IsoXmlTag("TaxClctdOnOrgnlAmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TaxCalculatedOnOriginalAmount { get; init; } 
    
    
    #nullable disable
    
}
