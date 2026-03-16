// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation request in a batch.
/// </summary>
[IsoId("_u-BdAY3SEeWjkqXgn_0Imw")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails31
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_vKGKIY3SEeWjkqXgn_0Imw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_vKGKI43SEeWjkqXgn_0Imw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_vKGKJY3SEeWjkqXgn_0Imw")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_vKGKJ43SEeWjkqXgn_0Imw")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount15? DetailedAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_vKGKKY3SEeWjkqXgn_0Imw")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Reason to process an online authorisation.
    /// </summary>
    [IsoId("_vKGKK43SEeWjkqXgn_0Imw")]
    [DisplayName("On Line Reason")]
    [IsoXmlTag("OnLineRsn")]
    public OnLineReason1Code? OnLineReason { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_vKGKLY3SEeWjkqXgn_0Imw")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_vKGKL43SEeWjkqXgn_0Imw")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_76J8QI3SEeWjkqXgn_0Imw")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion8? CurrencyConversionResult { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_vKGKMY3SEeWjkqXgn_0Imw")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; }

    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_vKGKM43SEeWjkqXgn_0Imw")]
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction2? AggregationTransaction { get; init; }

    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    [IsoId("_riWMIJILEeWww5VvitAAGw")]
    [DisplayName("Product Code Set Identification")]
    [IsoXmlTag("PdctCdSetId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ProductCodeSetIdentification { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_vKGKNY3SEeWjkqXgn_0Imw")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public ValueList<Product3> SaleItem { get; init; } = [];

    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_vWbrQJVMEeWu36UkS2TkoQ")]
    [DisplayName("Delivery Location")]
    [IsoXmlTag("DlvryLctn")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? DeliveryLocation { get; init; }

    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_vKGKN43SEeWjkqXgn_0Imw")]
    [DisplayName("Card Payment Invoice")]
    [IsoXmlTag("CardPmtInvc")]
    public CardPaymentInvoice2? CardPaymentInvoice { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_vKGKOY3SEeWjkqXgn_0Imw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
