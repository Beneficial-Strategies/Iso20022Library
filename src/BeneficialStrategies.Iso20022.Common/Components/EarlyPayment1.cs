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
[IsoId("_T6ZIUVm_EeOQYsoJizpkVw")]
[DisplayName("Early Payment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EarlyPayment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EarlyPayment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EarlyPayment1( System.DateOnly reqEarlyPaymentDate,System.Decimal reqDiscountPercent,CurrencyAndAmount reqDiscountAmount )
    {
        EarlyPaymentDate = reqEarlyPaymentDate;
        DiscountPercent = reqDiscountPercent;
        DiscountAmount = reqDiscountAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date before which the early payment discount is valid for payment.
    /// </summary>
    [IsoId("_eUAngFm_EeOQYsoJizpkVw")]
    [DisplayName("Early Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyPmtDt")]
    #endif
    [IsoXmlTag("EarlyPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate EarlyPaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly EarlyPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly EarlyPaymentDate { get; init; } 
    #else
    public System.DateOnly EarlyPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Discount percent for early payment.
    /// </summary>
    [IsoId("_UGcnaVm_EeOQYsoJizpkVw")]
    [DisplayName("Discount Percent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntPct")]
    #endif
    [IsoXmlTag("DscntPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate DiscountPercent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal DiscountPercent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal DiscountPercent { get; init; } 
    #else
    public System.Decimal DiscountPercent { get; set; } 
    #endif
    
    /// <summary>
    /// Early payment discount with tax, with currency.
    /// </summary>
    [IsoId("_UGcnZVm_EeOQYsoJizpkVw")]
    [DisplayName("Discount Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntAmt")]
    #endif
    [IsoXmlTag("DscntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount DiscountAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount DiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount DiscountAmount { get; init; } 
    #else
    public CurrencyAndAmount DiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// In tax specification for early payment discount one defined the applied tax rates for specific early payment. VAT stands for value added tax.
    /// </summary>
    [IsoId("_EkXkEFnAEeOQYsoJizpkVw")]
    [DisplayName("Early Payment Tax Specification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyPmtTaxSpcfctn")]
    #endif
    [IsoXmlTag("EarlyPmtTaxSpcfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EarlyPaymentsVAT1? EarlyPaymentTaxSpecification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EarlyPaymentsVAT1? EarlyPaymentTaxSpecification { get; init; } 
    #else
    public EarlyPaymentsVAT1? EarlyPaymentTaxSpecification { get; set; } 
    #endif
    
    /// <summary>
    /// Tax total in early payment, with currency.
    /// </summary>
    [IsoId("_sh6QoFm_EeOQYsoJizpkVw")]
    [DisplayName("Early Payment Tax Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyPmtTaxTtl")]
    #endif
    [IsoXmlTag("EarlyPmtTaxTtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? EarlyPaymentTaxTotal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? EarlyPaymentTaxTotal { get; init; } 
    #else
    public CurrencyAndAmount? EarlyPaymentTaxTotal { get; set; } 
    #endif
    
    /// <summary>
    /// Payable amount with discount of early payment, with currency.
    /// </summary>
    [IsoId("_3UqokFm_EeOQYsoJizpkVw")]
    [DisplayName("Due Payable Amount With Early Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DuePyblAmtWthEarlyPmt")]
    #endif
    [IsoXmlTag("DuePyblAmtWthEarlyPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? DuePayableAmountWithEarlyPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? DuePayableAmountWithEarlyPayment { get; init; } 
    #else
    public CurrencyAndAmount? DuePayableAmountWithEarlyPayment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
