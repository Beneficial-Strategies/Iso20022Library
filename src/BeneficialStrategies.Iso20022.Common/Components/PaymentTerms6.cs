// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms of the underlying transaction.
/// </summary>
[IsoId("_ODM5MDI2-AOSNFX-3397728")]
[DisplayName("Payment Terms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTerms6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Due date specified for the payment terms.
    /// </summary>
    [IsoId("_ODM5MDI3-AOSNFX-3397728")]
    [DisplayName("Due Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DueDt")]
    #endif
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DueDate { get; init; } 
    #else
    public System.DateOnly? DueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Payment period specified for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDI4-AOSNFX-3397728")]
    [DisplayName("Payment Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtPrd")]
    #endif
    [IsoXmlTag("PmtPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentPeriod1? PaymentPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentPeriod1? PaymentPeriod { get; init; } 
    #else
    public PaymentPeriod1? PaymentPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Textual description of these payment terms.
    /// </summary>
    [IsoId("_ODM5MDI5-AOSNFX-3397728")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Partial payment, expressed as a percentage, for the payment terms.
    /// </summary>
    [IsoId("_ODM5MDMw-AOSNFX-3397728")]
    [DisplayName("Partial Payment Percent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlPmtPct")]
    #endif
    [IsoXmlTag("PrtlPmtPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PartialPaymentPercent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PartialPaymentPercent { get; init; } 
    #else
    public System.Decimal? PartialPaymentPercent { get; set; } 
    #endif
    
    /// <summary>
    /// Direct debit mandate identification specified for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDMx-AOSNFX-3397728")]
    [DisplayName("Direct Debit Mandate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtMndtId")]
    #endif
    [IsoXmlTag("DrctDbtMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DirectDebitMandateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DirectDebitMandateIdentification { get; init; } 
    #else
    public System.String? DirectDebitMandateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used as a basis to calculate the discount amount for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDMy-AOSNFX-3397728")]
    [DisplayName("Basis Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisAmt")]
    #endif
    [IsoXmlTag("BsisAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? BasisAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? BasisAmount { get; init; } 
    #else
    public CurrencyAndAmount? BasisAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that results from the application of an agreed discount percentage to the basis amount and payable to the creditor.
    /// </summary>
    [IsoId("_ODM5MDMz-AOSNFX-3397729")]
    [DisplayName("Discount Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntAmt")]
    #endif
    [IsoXmlTag("DscntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? DiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? DiscountAmount { get; init; } 
    #else
    public CurrencyAndAmount? DiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percent rate used to calculate the discount for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDM0-AOSNFX-3397729")]
    [DisplayName("Discount Percent Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntPctRate")]
    #endif
    [IsoXmlTag("DscntPctRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? DiscountPercentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DiscountPercentRate { get; init; } 
    #else
    public System.Decimal? DiscountPercentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that results from the application of an agreed penalty percentage to the basis amount and payable by the creditor.
    /// </summary>
    [IsoId("_ODM5MDM1-AOSNFX-3397729")]
    [DisplayName("Penalty Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PnltyAmt")]
    #endif
    [IsoXmlTag("PnltyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? PenaltyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? PenaltyAmount { get; init; } 
    #else
    public CurrencyAndAmount? PenaltyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percent rate used to calculate the penalty for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDM2-AOSNFX-3397729")]
    [DisplayName("Penalty Percent Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PnltyPctRate")]
    #endif
    [IsoXmlTag("PnltyPctRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PenaltyPercentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PenaltyPercentRate { get; init; } 
    #else
    public System.Decimal? PenaltyPercentRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
