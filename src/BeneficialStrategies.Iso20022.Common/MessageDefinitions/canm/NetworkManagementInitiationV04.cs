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

namespace BeneficialStrategies.Iso20022.canm;

/// <summary>
/// This record is an implementation of the canm.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_xPdQMZLMEe6TWIDarRgYow")]
[DisplayName("Network Management Initiation V04")]
public record NetworkManagementInitiationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "canm.001.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtwkMgmtInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.001.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

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
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header71 Header { get; init; }

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
    /// Maximum Number Of Messages.
    /// </summary>
    [DisplayName("Maximum Number Of Messages")]
    [IsoXmlTag("MaxNbOfMsgs")]
    public IsoNumber? MaximumNumberOfMessages { get; init; }

    /// <summary>
    /// Message Reason.
    /// </summary>
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Network Management Type.
    /// </summary>
    [DisplayName("Network Management Type")]
    [IsoXmlTag("NtwkMgmtTp")]
    public NetworkManagementType1Code? NetworkManagementType { get; init; }

    /// <summary>
    /// Number Of Messages.
    /// </summary>
    [DisplayName("Number Of Messages")]
    [IsoXmlTag("NbOfMsgs")]
    public IsoNumber? NumberOfMessages { get; init; }

    /// <summary>
    /// Original Response Code.
    /// </summary>
    [DisplayName("Original Response Code")]
    [IsoXmlTag("OrgnlRspnCd")]
    public ISO8583ResponseCode? OriginalResponseCode { get; init; }

    /// <summary>
    /// Other Network Management Type.
    /// </summary>
    [DisplayName("Other Network Management Type")]
    [IsoXmlTag("OthrNtwkMgmtTp")]
    public IsoMax35Text? OtherNetworkManagementType { get; init; }

    /// <summary>
    /// Processing Result.
    /// </summary>
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult26? ProcessingResult { get; init; }

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ProgrammeMode5? Programme { get; init; }

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

// Since NetworkManagementInitiationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetworkManagementInitiationV04.
