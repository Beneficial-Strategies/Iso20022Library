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
[IsoId("_Pvj04XDoEe2MCaKO5AtGsA")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails52
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_P2b48XDoEe2MCaKO5AtGsA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_P2b483DoEe2MCaKO5AtGsA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Contains the updated amount of all authorisations related to the same business transaction.
    /// </summary>
    [IsoId("_P2b49XDoEe2MCaKO5AtGsA")]
    [DisplayName("Cumulative Amount")]
    [IsoXmlTag("CmltvAmt")]
    public ImpliedCurrencyAndAmount? CumulativeAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_P2b493DoEe2MCaKO5AtGsA")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount8Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_P2b4-XDoEe2MCaKO5AtGsA")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount15? DetailedAmount { get; init; }

    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_P2b4-3DoEe2MCaKO5AtGsA")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Amount authorised for the payment transaction.
    /// </summary>
    [IsoId("_P2b4_XDoEe2MCaKO5AtGsA")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; }

    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [IsoId("_P2b4_3DoEe2MCaKO5AtGsA")]
    [DisplayName("Invoice Amount")]
    [IsoXmlTag("InvcAmt")]
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_P2b5AXDoEe2MCaKO5AtGsA")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Reason to process an online authorisation.
    /// </summary>
    [IsoId("_P2b5A3DoEe2MCaKO5AtGsA")]
    [DisplayName("On Line Reason")]
    [IsoXmlTag("OnLineRsn")]
    public OnLineReason2Code? OnLineReason { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_P2b5BXDoEe2MCaKO5AtGsA")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_P2b5B3DoEe2MCaKO5AtGsA")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_P2b5CXDoEe2MCaKO5AtGsA")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion27? CurrencyConversionResult { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_P2b5C3DoEe2MCaKO5AtGsA")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction5? Instalment { get; init; }

    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_P2b5DXDoEe2MCaKO5AtGsA")]
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction3? AggregationTransaction { get; init; }

    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    [IsoId("_P2b5D3DoEe2MCaKO5AtGsA")]
    [DisplayName("Product Code Set Identification")]
    [IsoXmlTag("PdctCdSetId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ProductCodeSetIdentification { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_P2b5EXDoEe2MCaKO5AtGsA")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public Product6? SaleItem { get; init; }

    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_P2b5E3DoEe2MCaKO5AtGsA")]
    [DisplayName("Delivery Location")]
    [IsoXmlTag("DlvryLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DeliveryLocation { get; init; }

    /// <summary>
    /// In case a message is sent after the consumption of goods or service, it indicates the number of times the authorisation has been sent to the Acquirer in order to get an approval.
    /// </summary>
    [IsoId("_P2b5FXDoEe2MCaKO5AtGsA")]
    [DisplayName("Re Submission Counter")]
    [IsoXmlTag("ReSubmissnCntr")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? ReSubmissionCounter { get; init; }

    /// <summary>
    /// Additional information related to the transaction like an Invoice or IndustryData (for example  hospitality, lodging, transportation).
    /// </summary>
    [IsoId("_P2b5F3DoEe2MCaKO5AtGsA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ExternallyDefinedData4? AdditionalInformation { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_P2b5GXDoEe2MCaKO5AtGsA")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
