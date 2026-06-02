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
[IsoId("_S0AtQbZjEfCUZfsQO4rYeA")]
[DisplayName("Card Payment Transaction Details54")]
public record CardPaymentTransactionDetails54
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_S1CoBbZjEfCUZfsQO4rYeA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_S1CoC7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Contains the updated amount of all authorisations related to the same business transaction.
    /// </summary>
    [IsoId("_S1CoEbZjEfCUZfsQO4rYeA")]
    [DisplayName("Cumulative Amount")]
    [IsoXmlTag("CmltvAmt")]
    public ImpliedCurrencyAndAmount? CumulativeAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_S1CoF7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount8Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_S1CoHbZjEfCUZfsQO4rYeA")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount15? DetailedAmount { get; init; }

    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_S1CoI7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Amount authorised for the payment transaction.
    /// </summary>
    [IsoId("_S1CoKbZjEfCUZfsQO4rYeA")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AutorsdAmt")]
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; }

    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [IsoId("_S1CoL7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Invoice Amount")]
    [IsoXmlTag("InvcAmt")]
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_S1CoNbZjEfCUZfsQO4rYeA")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Reason to process an online authorisation.
    /// </summary>
    [IsoId("_S1CoO7ZjEfCUZfsQO4rYeA")]
    [DisplayName("On Line Reason")]
    [IsoXmlTag("OnLineRsn")]
    public SimpleValueList<OnLineReason2Code> OnLineReason { get; init; } = [];

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_S1CoQbZjEfCUZfsQO4rYeA")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_S1CoR7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_S1CoTbZjEfCUZfsQO4rYeA")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion35? CurrencyConversionResult { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment).
    /// </summary>
    [IsoId("_S1CoU7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public ValueList<Instalment7> Instalment { get; init; } = [];

    /// <summary>
    /// Data related to a recurring transaction.
    /// </summary>
    [IsoId("_S1CoWbZjEfCUZfsQO4rYeA")]
    [DisplayName("Recurring")]
    [IsoXmlTag("Rcrng")]
    public RecurringTransaction7? Recurring { get; init; }

    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_S1CoW7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction3? AggregationTransaction { get; init; }

    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    [IsoId("_S1CoYbZjEfCUZfsQO4rYeA")]
    [DisplayName("Product Code Set Identification")]
    [IsoXmlTag("PdctCdSetId")]
    public IsoMax10Text? ProductCodeSetIdentification { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_S1CoZ7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public ValueList<Product6> SaleItem { get; init; } = [];

    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_S1CobbZjEfCUZfsQO4rYeA")]
    [DisplayName("Delivery Location")]
    [IsoXmlTag("DlvryLctn")]
    public IsoMax35Text? DeliveryLocation { get; init; }

    /// <summary>
    /// In case a message is sent after the consumption of goods or service, it indicates the number of times the authorisation has been sent to the Acquirer in order to get an approval.
    /// </summary>
    [IsoId("_S1Coc7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Re Submission Counter")]
    [IsoXmlTag("ReSubmissnCntr")]
    public IsoPositiveNumber? ReSubmissionCounter { get; init; }

    /// <summary>
    /// Total Number of Completion related to the authorisation of this transaction.
    /// </summary>
    [IsoId("_S1CoebZjEfCUZfsQO4rYeA")]
    [DisplayName("Completion Sequence Number")]
    [IsoXmlTag("CmpltnSeqNb")]
    public IsoPositiveNumber? CompletionSequenceNumber { get; init; }

    /// <summary>
    /// Identification in the Sequence of the Completion related to the authorisation of this transaction.
    /// </summary>
    [IsoId("_S1Coe7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Completion Sequence Counter")]
    [IsoXmlTag("CmpltnSeqCntr")]
    public IsoPositiveNumber? CompletionSequenceCounter { get; init; }

    /// <summary>
    /// Total Amount authorised for the payment transaction when a sequence of completion is used.
    /// </summary>
    [IsoId("_S1CofbZjEfCUZfsQO4rYeA")]
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; }

    /// <summary>
    /// Additional information related to the transaction like an Invoice or IndustryData.
    /// </summary>
    [IsoId("_S1Cof7ZjEfCUZfsQO4rYeA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<ExternallyDefinedData5> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_S1CohbZjEfCUZfsQO4rYeA")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
