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
/// Trade settlement details for this invoice which involves the payment of an outstanding debt, account, or charge.
/// </summary>
[IsoId("_OFO6gVm5EeOQYsoJizpkVw")]
[DisplayName("Trade Settlement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeSettlement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeSettlement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeSettlement2( CurrencyAndAmount reqDuePayableAmount,CurrencyAndAmount reqTaxTotalAmount )
    {
        DuePayableAmount = reqDuePayableAmount;
        TaxTotalAmount = reqTaxTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Payment or creditor reference.
    /// </summary>
    [IsoId("_RStLoKCpEeSA-fWAnLdNiw")]
    [DisplayName("Payment Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRef")]
    #endif
    [IsoXmlTag("PmtRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorReferenceInformation2? PaymentReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorReferenceInformation2? PaymentReference { get; init; } 
    #else
    public CreditorReferenceInformation2? PaymentReference { get; set; } 
    #endif
    
    /// <summary>
    /// Date when invoice should be paid.
    /// </summary>
    [IsoId("_JESTsFm6EeOQYsoJizpkVw")]
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
    /// Payable amount with currency code.
    /// </summary>
    [IsoId("_OSxAMVm5EeOQYsoJizpkVw")]
    [DisplayName("Due Payable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DuePyblAmt")]
    #endif
    [IsoXmlTag("DuePyblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount DuePayableAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount DuePayableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount DuePayableAmount { get; init; } 
    #else
    public CurrencyAndAmount DuePayableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// If invoice currency is different from local tax reporting currency, then applied exchange rate is given in this message structure.
    /// </summary>
    [IsoId("_HJg08KuoEeSmE8_WfXaYYg")]
    [DisplayName("Invoice Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcCcyXchg")]
    #endif
    [IsoXmlTag("InvcCcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyReference3? InvoiceCurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyReference3? InvoiceCurrencyExchange { get; init; } 
    #else
    public CurrencyReference3? InvoiceCurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Date when goods/services are delivered to buyer.
    /// </summary>
    [IsoId("_fcGEIKtdEeSqWL9DOn1OKw")]
    [DisplayName("Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDt")]
    #endif
    [IsoXmlTag("DlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DeliveryDate { get; init; } 
    #else
    public System.DateOnly? DeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which delivery executed or agreed invoicing period.
    /// </summary>
    [IsoId("_LfRuQB-6EeW5Rpfp6VSoCg")]
    [DisplayName("Billing Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgPrd")]
    #endif
    [IsoXmlTag("BllgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period2? BillingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period2? BillingPeriod { get; init; } 
    #else
    public Period2? BillingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Tax total amount with currency code.
    /// </summary>
    [IsoId("_VON58Fm6EeOQYsoJizpkVw")]
    [DisplayName("Tax Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTtlAmt")]
    #endif
    [IsoXmlTag("TaxTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount TaxTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount TaxTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount TaxTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount TaxTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for tax exemption expressed as a code, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_p8ZTIKuqEeSmE8_WfXaYYg")]
    [DisplayName("Exemption Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnRsnCd")]
    #endif
    [IsoXmlTag("XmptnRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? ExemptionReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExemptionReasonCode { get; init; } 
    #else
    public System.String? ExemptionReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for a tax exemption, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_FU2aQFnKEeOQYsoJizpkVw")]
    [DisplayName("Exemption Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnRsn")]
    #endif
    [IsoXmlTag("XmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? ExemptionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExemptionReason { get; init; } 
    #else
    public System.String? ExemptionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Calculated tax subtotal.
    /// </summary>
    [IsoId("_OSxAbVm5EeOQYsoJizpkVw")]
    [DisplayName("Sub Total Calculated Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTtlClctdTax")]
    #endif
    [IsoXmlTag("SubTtlClctdTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementSubTotalCalculatedTax2? SubTotalCalculatedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementSubTotalCalculatedTax2? SubTotalCalculatedTax { get; init; } 
    #else
    public SettlementSubTotalCalculatedTax2? SubTotalCalculatedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Details of each early payment discount.
    /// </summary>
    [IsoId("_osa_kEWmEeWZBsWfSGYWYg")]
    [DisplayName("Early Payments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyPmts")]
    #endif
    [IsoXmlTag("EarlyPmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EarlyPayment1? EarlyPayments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EarlyPayment1? EarlyPayments { get; init; } 
    #else
    public EarlyPayment1? EarlyPayments { get; set; } 
    #endif
    
    
    #nullable disable
    
}
