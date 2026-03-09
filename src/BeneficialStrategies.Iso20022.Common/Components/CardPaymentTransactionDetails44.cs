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
/// Details of the transaction in the completion advice.
/// </summary>
[IsoId("_3kZIcdncEeeN3v2fup_Shw")]
[DisplayName("Card Payment Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransactionDetails44
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransactionDetails44 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransactionDetails44( ImpliedCurrencyAndAmount reqTotalAmount )
    {
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_3tO7YdncEeeN3v2fup_Shw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_3tO7Y9ncEeeN3v2fup_Shw")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_3tO7ZdncEeeN3v2fup_Shw")]
    [DisplayName("Amount Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtQlfr")]
    #endif
    [IsoXmlTag("AmtQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount8Code? AmountQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount8Code? AmountQualifier { get; init; } 
    #else
    public TypeOfAmount8Code? AmountQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_3tO7Z9ncEeeN3v2fup_Shw")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount15? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount15? DetailedAmount { get; init; } 
    #else
    public DetailedAmount15? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_3tO7adncEeeN3v2fup_Shw")]
    [DisplayName("Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdAmt")]
    #endif
    [IsoXmlTag("ReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? RequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount authorised for the payment transaction.
    /// </summary>
    [IsoId("_3tO7a9ncEeeN3v2fup_Shw")]
    [DisplayName("Authorised Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrsdAmt")]
    #endif
    [IsoXmlTag("AuthrsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [IsoId("_3tO7bdncEeeN3v2fup_Shw")]
    [DisplayName("Invoice Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcAmt")]
    #endif
    [IsoXmlTag("InvcAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_3tO7b9ncEeeN3v2fup_Shw")]
    [DisplayName("Validity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyDt")]
    #endif
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidityDate { get; init; } 
    #else
    public System.DateOnly? ValidityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_3tO7cdncEeeN3v2fup_Shw")]
    [DisplayName("Unattended Level Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UattnddLvlCtgy")]
    #endif
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnattendedLevelCategory { get; init; } 
    #else
    public System.String? UnattendedLevelCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_3tO7c9ncEeeN3v2fup_Shw")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType3Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType3Code? AccountType { get; init; } 
    #else
    public CardAccountType3Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the currency conversion proposed to the cardholder and its result.
    /// </summary>
    [IsoId("_3tO7ddncEeeN3v2fup_Shw")]
    [DisplayName("Currency Conversion Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsRslt")]
    #endif
    [IsoXmlTag("CcyConvsRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion15? CurrencyConversionResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion15? CurrencyConversionResult { get; init; } 
    #else
    public CurrencyConversion15? CurrencyConversionResult { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_3tO7d9ncEeeN3v2fup_Shw")]
    [DisplayName("Instalment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instlmt")]
    #endif
    [IsoXmlTag("Instlmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecurringTransaction2? Instalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecurringTransaction2? Instalment { get; init; } 
    #else
    public RecurringTransaction2? Instalment { get; set; } 
    #endif
    
    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_3tO7edncEeeN3v2fup_Shw")]
    [DisplayName("Aggregation Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AggtnTx")]
    #endif
    [IsoXmlTag("AggtnTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregationTransaction2? AggregationTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregationTransaction2? AggregationTransaction { get; init; } 
    #else
    public AggregationTransaction2? AggregationTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    [IsoId("_3tO7e9ncEeeN3v2fup_Shw")]
    [DisplayName("Product Code Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCdSetId")]
    #endif
    [IsoXmlTag("PdctCdSetId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? ProductCodeSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductCodeSetIdentification { get; init; } 
    #else
    public System.String? ProductCodeSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_3tO7fdncEeeN3v2fup_Shw")]
    [DisplayName("Sale Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleItm")]
    #endif
    [IsoXmlTag("SaleItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product3? SaleItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product3? SaleItem { get; init; } 
    #else
    public Product3? SaleItem { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_3tO7f9ncEeeN3v2fup_Shw")]
    [DisplayName("Delivery Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryLctn")]
    #endif
    [IsoXmlTag("DlvryLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DeliveryLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryLocation { get; init; } 
    #else
    public System.String? DeliveryLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_3tO7gdncEeeN3v2fup_Shw")]
    [DisplayName("Card Payment Invoice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPmtInvc")]
    #endif
    [IsoXmlTag("CardPmtInvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentInvoice3? CardPaymentInvoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentInvoice3? CardPaymentInvoice { get; init; } 
    #else
    public CardPaymentInvoice3? CardPaymentInvoice { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_3tO7g9ncEeeN3v2fup_Shw")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ICCRelatedData { get; init; } 
    #else
    public System.Byte[]? ICCRelatedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
