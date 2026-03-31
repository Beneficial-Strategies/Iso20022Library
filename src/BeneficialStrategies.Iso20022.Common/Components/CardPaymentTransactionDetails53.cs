// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Transaction Details53.
/// </summary>
[IsoId("_hAn3sZHoEe6qwqnYOGEReg")]
[DisplayName("Card Payment Transaction Details53")]
public record CardPaymentTransactionDetails53
{
    /// <summary>
    /// Account Type.
    /// </summary>
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<ExternallyDefinedData5> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Aggregation Transaction.
    /// </summary>
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction3? AggregationTransaction { get; init; }

    /// <summary>
    /// Amount Qualifier.
    /// </summary>
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount8Code? AmountQualifier { get; init; }

    /// <summary>
    /// Authorised Amount.
    /// </summary>
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; }

    /// <summary>
    /// Completion Sequence Counter.
    /// </summary>
    [DisplayName("Completion Sequence Counter")]
    [IsoXmlTag("CmpltnSeqCntr")]
    public IsoPositiveNumber? CompletionSequenceCounter { get; init; }

    /// <summary>
    /// Completion Sequence Number.
    /// </summary>
    [DisplayName("Completion Sequence Number")]
    [IsoXmlTag("CmpltnSeqNb")]
    public IsoPositiveNumber? CompletionSequenceNumber { get; init; }

    /// <summary>
    /// Cumulative Amount.
    /// </summary>
    [DisplayName("Cumulative Amount")]
    [IsoXmlTag("CmltvAmt")]
    public ImpliedCurrencyAndAmount? CumulativeAmount { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Currency Conversion Result.
    /// </summary>
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion30? CurrencyConversionResult { get; init; }

    /// <summary>
    /// Delivery Location.
    /// </summary>
    [DisplayName("Delivery Location")]
    [IsoXmlTag("DlvryLctn")]
    public IsoMax35Text? DeliveryLocation { get; init; }

    /// <summary>
    /// Detailed Amount.
    /// </summary>
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount15? DetailedAmount { get; init; }

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Instalment.
    /// </summary>
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public ValueList<Instalment5> Instalment { get; init; } = [];

    /// <summary>
    /// Invoice Amount.
    /// </summary>
    [DisplayName("Invoice Amount")]
    [IsoXmlTag("InvcAmt")]
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; }

    /// <summary>
    /// On Line Reason.
    /// </summary>
    [DisplayName("On Line Reason")]
    [IsoXmlTag("OnLineRsn")]
    public ValueList<OnLineReason2Code> OnLineReason { get; init; } = [];

    /// <summary>
    /// Product Code Set Identification.
    /// </summary>
    [DisplayName("Product Code Set Identification")]
    [IsoXmlTag("PdctCdSetId")]
    public IsoMax10Text? ProductCodeSetIdentification { get; init; }

    /// <summary>
    /// Recurring.
    /// </summary>
    [DisplayName("Recurring")]
    [IsoXmlTag("Rcrng")]
    public RecurringTransaction6? Recurring { get; init; }

    /// <summary>
    /// Requested Amount.
    /// </summary>
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Re Submission Counter.
    /// </summary>
    [DisplayName("Re Submission Counter")]
    [IsoXmlTag("ReSubmissnCntr")]
    public IsoPositiveNumber? ReSubmissionCounter { get; init; }

    /// <summary>
    /// Sale Item.
    /// </summary>
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public ValueList<Product6> SaleItem { get; init; } = [];

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Total Authorised Amount.
    /// </summary>
    [DisplayName("Total Authorised Amount")]
    [IsoXmlTag("TtlAuthrsdAmt")]
    public ImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; }

    /// <summary>
    /// Unattended Level Category.
    /// </summary>
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Validity Date.
    /// </summary>
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    public IsoISODate? ValidityDate { get; init; }
}
