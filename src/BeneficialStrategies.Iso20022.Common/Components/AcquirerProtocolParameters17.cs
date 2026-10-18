// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer Protocol Parameters17.
/// </summary>
[IsoId("_sd6csZ9uEe-nbM0aSPcoiQ")]
[DisplayName("Acquirer Protocol Parameters17")]
public record AcquirerProtocolParameters17
{
    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Acquirer Identification.
    /// </summary>
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification176> AcquirerIdentification { get; init; } = [];

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required Max256Text Version { get; init; }

    /// <summary>
    /// Application Identification.
    /// </summary>
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public ValueList<Max35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Host.
    /// </summary>
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration10> Host { get; init; } = [];

    /// <summary>
    /// On Line Transaction.
    /// </summary>
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolExchangeBehavior2? OnLineTransaction { get; init; }

    /// <summary>
    /// Off Line Transaction.
    /// </summary>
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolExchangeBehavior2? OffLineTransaction { get; init; }

    /// <summary>
    /// Reconciliation Exchange.
    /// </summary>
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration9? ReconciliationExchange { get; init; }

    /// <summary>
    /// Reconciliation By Acquirer.
    /// </summary>
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    public TrueFalseIndicator? ReconciliationByAcquirer { get; init; }

    /// <summary>
    /// Totals Per Currency.
    /// </summary>
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    public TrueFalseIndicator? TotalsPerCurrency { get; init; }

    /// <summary>
    /// Split Totals.
    /// </summary>
    [DisplayName("Split Totals")]
    [IsoXmlTag("SpltTtls")]
    public TrueFalseIndicator? SplitTotals { get; init; }

    /// <summary>
    /// Split Total Criteria.
    /// </summary>
    [DisplayName("Split Total Criteria")]
    [IsoXmlTag("SpltTtlCrit")]
    public ValueList<ReconciliationCriteria1Code> SplitTotalCriteria { get; init; } = [];

    /// <summary>
    /// Completion Advice Mandated.
    /// </summary>
    [DisplayName("Completion Advice Mandated")]
    [IsoXmlTag("CmpltnAdvcMndtd")]
    public TrueFalseIndicator? CompletionAdviceMandated { get; init; }

    /// <summary>
    /// Amount Qualifier For Reservation.
    /// </summary>
    [DisplayName("Amount Qualifier For Reservation")]
    [IsoXmlTag("AmtQlfrForRsvatn")]
    public ValueList<TypeOfAmount8Code> AmountQualifierForReservation { get; init; } = [];

    /// <summary>
    /// Reconciliation Error.
    /// </summary>
    [DisplayName("Reconciliation Error")]
    [IsoXmlTag("RcncltnErr")]
    public TrueFalseIndicator? ReconciliationError { get; init; }

    /// <summary>
    /// Card Data Verification.
    /// </summary>
    [DisplayName("Card Data Verification")]
    [IsoXmlTag("CardDataVrfctn")]
    public TrueFalseIndicator? CardDataVerification { get; init; }

    /// <summary>
    /// Notify Off Line Cancellation.
    /// </summary>
    [DisplayName("Notify Off Line Cancellation")]
    [IsoXmlTag("NtfyOffLineCxl")]
    public TrueFalseIndicator? NotifyOffLineCancellation { get; init; }

    /// <summary>
    /// Batch Transfer Content.
    /// </summary>
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public ValueList<BatchTransactionType1Code> BatchTransferContent { get; init; } = [];

    /// <summary>
    /// File Transfer Batch.
    /// </summary>
    [DisplayName("File Transfer Batch")]
    [IsoXmlTag("FileTrfBtch")]
    public TrueFalseIndicator? FileTransferBatch { get; init; }

    /// <summary>
    /// Batch Digital Signature.
    /// </summary>
    [DisplayName("Batch Digital Signature")]
    [IsoXmlTag("BtchDgtlSgntr")]
    public TrueFalseIndicator? BatchDigitalSignature { get; init; }

    /// <summary>
    /// Message Item.
    /// </summary>
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    /// <summary>
    /// Protect Card Data.
    /// </summary>
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    public required TrueFalseIndicator ProtectCardData { get; init; }

    /// <summary>
    /// Private Card Data.
    /// </summary>
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    public TrueFalseIndicator? PrivateCardData { get; init; }

    /// <summary>
    /// Mandatory Security Trailer.
    /// </summary>
    [DisplayName("Mandatory Security Trailer")]
    [IsoXmlTag("MndtrySctyTrlr")]
    public TrueFalseIndicator? MandatorySecurityTrailer { get; init; }
}
