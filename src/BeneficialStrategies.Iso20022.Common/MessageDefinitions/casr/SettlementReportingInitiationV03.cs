// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.casr;

/// <summary>
/// This record is an implementation of the casr.001.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_sMvjkZjHEe6OBt2eQPMPsQ")]
[DisplayName("Settlement Reporting Initiation V03")]
public record SettlementReportingInitiationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casr.001.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmRptgInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casr.001.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Acquirer Settlement Totals.
    /// </summary>
    [DisplayName("Acquirer Settlement Totals")]
    [IsoXmlTag("AcqrrSttlmTtls")]
    public SettlementCategoryTotal3? AcquirerSettlementTotals { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData2> AdditionalData { get; init; } = [];

    /// <summary>
    /// Additional Fee.
    /// </summary>
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee3> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Alternate Message Reason.
    /// </summary>
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public ValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification286? Destination { get; init; }

    /// <summary>
    /// Financial Institution.
    /// </summary>
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution9? FinancialInstitution { get; init; }

    /// <summary>
    /// Funds Transfer Amount.
    /// </summary>
    [DisplayName("Funds Transfer Amount")]
    [IsoXmlTag("FndsTrfAmt")]
    public Amount17? FundsTransferAmount { get; init; }

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header71 Header { get; init; }

    /// <summary>
    /// Issuer Settlement Totals.
    /// </summary>
    [DisplayName("Issuer Settlement Totals")]
    [IsoXmlTag("IssrSttlmTtls")]
    public SettlementCategoryTotal3? IssuerSettlementTotals { get; init; }

    /// <summary>
    /// Jurisdiction.
    /// </summary>
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Life Cycle Identification.
    /// </summary>
    [DisplayName("Life Cycle Identification")]
    [IsoXmlTag("LifeCyclId")]
    public IsoExact15Text? LifeCycleIdentification { get; init; }

    /// <summary>
    /// Message Reason.
    /// </summary>
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification286? Originator { get; init; }

    /// <summary>
    /// Other Institution.
    /// </summary>
    [DisplayName("Other Institution")]
    [IsoXmlTag("OthrInstn")]
    public PartyIdentification285? OtherInstitution { get; init; }

    /// <summary>
    /// Other Settlement Report Type.
    /// </summary>
    [DisplayName("Other Settlement Report Type")]
    [IsoXmlTag("OthrSttlmRptTp")]
    public IsoMax35Text? OtherSettlementReportType { get; init; }

    /// <summary>
    /// Other Settlement Totals.
    /// </summary>
    [DisplayName("Other Settlement Totals")]
    [IsoXmlTag("OthrSttlmTtls")]
    public SettlementCategoryTotal3? OtherSettlementTotals { get; init; }

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ValueList<ProgrammeMode5> Programme { get; init; } = [];

    /// <summary>
    /// Protected Data.
    /// </summary>
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData2> ProtectedData { get; init; } = [];

    /// <summary>
    /// Receiver.
    /// </summary>
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification286? Receiver { get; init; }

    /// <summary>
    /// Reconciliation.
    /// </summary>
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation4? Reconciliation { get; init; }

    /// <summary>
    /// Retrieval Reference Number.
    /// </summary>
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; }

    /// <summary>
    /// Security Trailer.
    /// </summary>
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType41? SecurityTrailer { get; init; }

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification286? Sender { get; init; }

    /// <summary>
    /// Settlement Institution.
    /// </summary>
    [DisplayName("Settlement Institution")]
    [IsoXmlTag("SttlmInstn")]
    public PartyIdentification286? SettlementInstitution { get; init; }

    /// <summary>
    /// Settlement Report Type.
    /// </summary>
    [DisplayName("Settlement Report Type")]
    [IsoXmlTag("SttlmRptTp")]
    public required SettlementReportType1Code SettlementReportType { get; init; }

    /// <summary>
    /// Settlement Service.
    /// </summary>
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService6? SettlementService { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// System Trace Audit Number.
    /// </summary>
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Total Settlement Amount.
    /// </summary>
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public SettlementCategoryTotal2? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Transaction Description.
    /// </summary>
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Transmission Date Time.
    /// </summary>
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public required IsoISODateTime TransmissionDateTime { get; init; }
}

// Since SettlementReportingInitiationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SettlementReportingInitiationV03.
