// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the completion advice.
/// </summary>
[IsoId("_RAxa0Y09EeWPUZwhUA4U-w")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails29
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_RLgEIY09EeWPUZwhUA4U-w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_RLgEI409EeWPUZwhUA4U-w")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_RLgEJY09EeWPUZwhUA4U-w")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_RLgEJ409EeWPUZwhUA4U-w")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount15? DetailedAmount { get; init; }

    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_RLgEKY09EeWPUZwhUA4U-w")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Amount authorised for the payment transaction.
    /// </summary>
    [IsoId("_RLgEK409EeWPUZwhUA4U-w")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; }

    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [IsoId("_xQt_cJaFEeWuSaWgzo19MQ")]
    [DisplayName("Invoice Amount")]
    [IsoXmlTag("InvcAmt")]
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_RLgELY09EeWPUZwhUA4U-w")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_RLgEL409EeWPUZwhUA4U-w")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_RLgEMY09EeWPUZwhUA4U-w")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder and its result.
    /// </summary>
    [IsoId("_RLgEM409EeWPUZwhUA4U-w")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion8? CurrencyConversionResult { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_RLgENY09EeWPUZwhUA4U-w")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; }

    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_RLgEN409EeWPUZwhUA4U-w")]
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction2? AggregationTransaction { get; init; }

    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    [IsoId("_cZYB4JILEeWww5VvitAAGw")]
    [DisplayName("Product Code Set Identification")]
    [IsoXmlTag("PdctCdSetId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ProductCodeSetIdentification { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_RLgEOY09EeWPUZwhUA4U-w")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public ValueList<Product3> SaleItem { get; init; } = [];

    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_PUJagJVMEeWu36UkS2TkoQ")]
    [DisplayName("Delivery Location")]
    [IsoXmlTag("DlvryLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DeliveryLocation { get; init; }

    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_RLgEO409EeWPUZwhUA4U-w")]
    [DisplayName("Card Payment Invoice")]
    [IsoXmlTag("CardPmtInvc")]
    public CardPaymentInvoice2? CardPaymentInvoice { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_RLgEPY09EeWPUZwhUA4U-w")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
