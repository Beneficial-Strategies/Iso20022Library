// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer Protocol Parameters17.
/// </summary>
[IsoId("_sd6csZ9uEe-nbM0aSPcoiQ")]
[DisplayName("Acquirer Protocol Parameters17")]
public partial record AcquirerProtocolParameters17
{
    #nullable enable

    /// <summary>
    /// Acquirer Identification.
    /// </summary>
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public ValueList<GenericIdentification176> AcquirerIdentification { get; init; } = [];

    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 

    /// <summary>
    /// Amount Qualifier For Reservation.
    /// </summary>
    [DisplayName("Amount Qualifier For Reservation")]
    [IsoXmlTag("AmtQlfrForRsvatn")]
    public ValueList<TypeOfAmount8Code> AmountQualifierForReservation { get; init; } = [];

    /// <summary>
    /// Application Identification.
    /// </summary>
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public ValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Batch Digital Signature.
    /// </summary>
    [DisplayName("Batch Digital Signature")]
    [IsoXmlTag("BtchDgtlSgntr")]
    public IsoTrueFalseIndicator? BatchDigitalSignature { get; init; } 

    /// <summary>
    /// Batch Transfer Content.
    /// </summary>
    [DisplayName("Batch Transfer Content")]
    [IsoXmlTag("BtchTrfCntt")]
    public ValueList<BatchTransactionType1Code> BatchTransferContent { get; init; } = [];

    /// <summary>
    /// Card Data Verification.
    /// </summary>
    [DisplayName("Card Data Verification")]
    [IsoXmlTag("CardDataVrfctn")]
    public IsoTrueFalseIndicator? CardDataVerification { get; init; } 

    /// <summary>
    /// Completion Advice Mandated.
    /// </summary>
    [DisplayName("Completion Advice Mandated")]
    [IsoXmlTag("CmpltnAdvcMndtd")]
    public IsoTrueFalseIndicator? CompletionAdviceMandated { get; init; } 

    /// <summary>
    /// File Transfer Batch.
    /// </summary>
    [DisplayName("File Transfer Batch")]
    [IsoXmlTag("FileTrfBtch")]
    public IsoTrueFalseIndicator? FileTransferBatch { get; init; } 

    /// <summary>
    /// Host.
    /// </summary>
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration10> Host { get; init; } = [];

    /// <summary>
    /// Mandatory Security Trailer.
    /// </summary>
    [DisplayName("Mandatory Security Trailer")]
    [IsoXmlTag("MndtrySctyTrlr")]
    public IsoTrueFalseIndicator? MandatorySecurityTrailer { get; init; } 

    /// <summary>
    /// Message Item.
    /// </summary>
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    /// <summary>
    /// Notify Off Line Cancellation.
    /// </summary>
    [DisplayName("Notify Off Line Cancellation")]
    [IsoXmlTag("NtfyOffLineCxl")]
    public IsoTrueFalseIndicator? NotifyOffLineCancellation { get; init; } 

    /// <summary>
    /// Off Line Transaction.
    /// </summary>
    [DisplayName("Off Line Transaction")]
    [IsoXmlTag("OffLineTx")]
    public AcquirerProtocolExchangeBehavior2? OffLineTransaction { get; init; } 

    /// <summary>
    /// On Line Transaction.
    /// </summary>
    [DisplayName("On Line Transaction")]
    [IsoXmlTag("OnLineTx")]
    public AcquirerProtocolExchangeBehavior2? OnLineTransaction { get; init; } 

    /// <summary>
    /// Private Card Data.
    /// </summary>
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    public IsoTrueFalseIndicator? PrivateCardData { get; init; } 

    /// <summary>
    /// Protect Card Data.
    /// </summary>
    [DisplayName("Protect Card Data")]
    [IsoXmlTag("PrtctCardData")]
    public required IsoTrueFalseIndicator ProtectCardData { get; init; } 

    /// <summary>
    /// Reconciliation By Acquirer.
    /// </summary>
    [DisplayName("Reconciliation By Acquirer")]
    [IsoXmlTag("RcncltnByAcqrr")]
    public IsoTrueFalseIndicator? ReconciliationByAcquirer { get; init; } 

    /// <summary>
    /// Reconciliation Error.
    /// </summary>
    [DisplayName("Reconciliation Error")]
    [IsoXmlTag("RcncltnErr")]
    public IsoTrueFalseIndicator? ReconciliationError { get; init; } 

    /// <summary>
    /// Reconciliation Exchange.
    /// </summary>
    [DisplayName("Reconciliation Exchange")]
    [IsoXmlTag("RcncltnXchg")]
    public ExchangeConfiguration9? ReconciliationExchange { get; init; } 

    /// <summary>
    /// Split Total Criteria.
    /// </summary>
    [DisplayName("Split Total Criteria")]
    [IsoXmlTag("SpltTtlCrit")]
    public ValueList<ReconciliationCriteria1Code> SplitTotalCriteria { get; init; } = [];

    /// <summary>
    /// Split Totals.
    /// </summary>
    [DisplayName("Split Totals")]
    [IsoXmlTag("SpltTtls")]
    public IsoTrueFalseIndicator? SplitTotals { get; init; } 

    /// <summary>
    /// Totals Per Currency.
    /// </summary>
    [DisplayName("Totals Per Currency")]
    [IsoXmlTag("TtlsPerCcy")]
    public IsoTrueFalseIndicator? TotalsPerCurrency { get; init; } 

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; } 

    
    #nullable disable
    
}
