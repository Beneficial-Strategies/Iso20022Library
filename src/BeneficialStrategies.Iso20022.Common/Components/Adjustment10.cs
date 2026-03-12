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
[IsoId("_TMwPmPJ0EeiJn9rM2Znz2w")]
[DisplayName("Adjustment")]
public partial record Adjustment10
{
    #nullable enable
    
    /// <summary>
    /// Type of adjustment.
    /// </summary>
    [IsoId("_TMwPmvJ0EeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Additional information to specify the type of adjustment.
    /// </summary>
    [IsoId("_TMwPn_J0EeiJn9rM2Znz2w")]
    [DisplayName("Additional Type")]
    [IsoXmlTag("AddtlTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalType { get; init; } 
    
    /// <summary>
    /// Description of the adjustment.
    /// </summary>
    [IsoId("_TMwPnPJ0EeiJn9rM2Znz2w")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Description { get; init; } 
    
    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    [IsoId("_TMwPnfJ0EeiJn9rM2Znz2w")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    /// <summary>
    /// Identifies when the item is eligible or prohibited from a discount or adjustment.
    /// </summary>
    [IsoId("_C7lyEBs5EeqrvK3udMUsNQ")]
    [DisplayName("Promotion Eligibility")]
    [IsoXmlTag("PrmtnElgblty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PromotionEligibility { get; init; } 
    
    /// <summary>
    /// Promotion or adjustment code.
    /// </summary>
    [IsoId("_aVIAcfJ0EeiJn9rM2Znz2w")]
    [DisplayName("Promotion Code")]
    [IsoXmlTag("PrmtnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PromotionCode { get; init; } 
    
    /// <summary>
    /// May contain coupon number, discount code, etc.
    /// </summary>
    [IsoId("_qkzUEfJ0EeiJn9rM2Znz2w")]
    [DisplayName("Promotion Coupon Number")]
    [IsoXmlTag("PrmtnCpnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PromotionCouponNumber { get; init; } 
    
    /// <summary>
    /// Identifies the quantity of the item that is adjusted (can be less than the total quantity of the item being purchased).
    /// </summary>
    [IsoId("_q9zp8fJ0EeiJn9rM2Znz2w")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Quantity { get; init; } 
    
    /// <summary>
    /// Contains the adjusted unit price (does not include tax).
    /// </summary>
    [IsoId("_U7pIYfJ2EeiJn9rM2Znz2w")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    
    /// <summary>
    /// Contains the percentage value of the discount (when applicable).
    /// </summary>
    [IsoId("_TMwPmfJ0EeiJn9rM2Znz2w")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Percentage { get; init; } 
    
    /// <summary>
    /// Contains amount of the adjustment, exclusive of tax.
    /// </summary>
    [IsoId("_TMwPnvJ0EeiJn9rM2Znz2w")]
    [DisplayName("Adjustment Amount")]
    [IsoXmlTag("AdjstmntAmt")]
    public ImpliedCurrencyAndAmount? AdjustmentAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether or not tax was calculated on the original amount of the transaction. 
    /// Note that false (or not present) indicates applicable taxes are based on adjusted amount.
    /// </summary>
    [IsoId("_TMwPm_J0EeiJn9rM2Znz2w")]
    [DisplayName("Tax Calculated On Original Amount")]
    [IsoXmlTag("TaxClctdOnOrgnlAmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TaxCalculatedOnOriginalAmount { get; init; } 
    
    
    #nullable disable
    
}
