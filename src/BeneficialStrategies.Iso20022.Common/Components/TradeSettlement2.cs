// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade settlement details for this invoice which involves the payment of an outstanding debt, account, or charge.
/// </summary>
[IsoId("_OFO6gVm5EeOQYsoJizpkVw")]
[DisplayName("Trade Settlement")]
public partial record TradeSettlement2
{
    #nullable enable
    
    /// <summary>
    /// Payment or creditor reference.
    /// </summary>
    [IsoId("_RStLoKCpEeSA-fWAnLdNiw")]
    [DisplayName("Payment Reference")]
    [IsoXmlTag("PmtRef")]
    public CreditorReferenceInformation2? PaymentReference { get; init; } 
    
    /// <summary>
    /// Date when invoice should be paid.
    /// </summary>
    [IsoId("_JESTsFm6EeOQYsoJizpkVw")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; } 
    
    /// <summary>
    /// Payable amount with currency code.
    /// </summary>
    [IsoId("_OSxAMVm5EeOQYsoJizpkVw")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public required CurrencyAndAmount DuePayableAmount { get; init; } 
    
    /// <summary>
    /// If invoice currency is different from local tax reporting currency, then applied exchange rate is given in this message structure.
    /// </summary>
    [IsoId("_HJg08KuoEeSmE8_WfXaYYg")]
    [DisplayName("Invoice Currency Exchange")]
    [IsoXmlTag("InvcCcyXchg")]
    public CurrencyReference3? InvoiceCurrencyExchange { get; init; } 
    
    /// <summary>
    /// Date when goods/services are delivered to buyer.
    /// </summary>
    [IsoId("_fcGEIKtdEeSqWL9DOn1OKw")]
    [DisplayName("Delivery Date")]
    [IsoXmlTag("DlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeliveryDate { get; init; } 
    
    /// <summary>
    /// Period during which delivery executed or agreed invoicing period.
    /// </summary>
    [IsoId("_LfRuQB-6EeW5Rpfp6VSoCg")]
    [DisplayName("Billing Period")]
    [IsoXmlTag("BllgPrd")]
    public Period2? BillingPeriod { get; init; } 
    
    /// <summary>
    /// Tax total amount with currency code.
    /// </summary>
    [IsoId("_VON58Fm6EeOQYsoJizpkVw")]
    [DisplayName("Tax Total Amount")]
    [IsoXmlTag("TaxTtlAmt")]
    public required CurrencyAndAmount TaxTotalAmount { get; init; } 
    
    /// <summary>
    /// Reason for tax exemption expressed as a code, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_p8ZTIKuqEeSmE8_WfXaYYg")]
    [DisplayName("Exemption Reason Code")]
    [IsoXmlTag("XmptnRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? ExemptionReasonCode { get; init; } 
    
    /// <summary>
    /// Reason for a tax exemption, if invoice or card transaction is out of tax processing.
    /// </summary>
    [IsoId("_FU2aQFnKEeOQYsoJizpkVw")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? ExemptionReason { get; init; } 
    
    /// <summary>
    /// Calculated tax subtotal.
    /// </summary>
    [IsoId("_OSxAbVm5EeOQYsoJizpkVw")]
    [DisplayName("Sub Total Calculated Tax")]
    [IsoXmlTag("SubTtlClctdTax")]
    public SettlementSubTotalCalculatedTax2? SubTotalCalculatedTax { get; init; } 
    
    /// <summary>
    /// Details of each early payment discount.
    /// </summary>
    [IsoId("_osa_kEWmEeWZBsWfSGYWYg")]
    [DisplayName("Early Payments")]
    [IsoXmlTag("EarlyPmts")]
    public EarlyPayment1? EarlyPayments { get; init; } 
    
    
    #nullable disable
    
}
