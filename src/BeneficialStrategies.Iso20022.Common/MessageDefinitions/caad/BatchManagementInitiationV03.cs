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

namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// This record is an implementation of the caad.001.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_qFMfoY0_Ee6S0_1AaJzQCA")]
[DisplayName("Batch Management Initiation V03")]
public record BatchManagementInitiationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.001.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchMgmtInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.001.001.03";

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
    /// Batch Checksum.
    /// </summary>
    [DisplayName("Batch Checksum")]
    [IsoXmlTag("BtchChcksm")]
    public IsoMax35Binary? BatchChecksum { get; init; }

    /// <summary>
    /// Batch Identification.
    /// </summary>
    [DisplayName("Batch Identification")]
    [IsoXmlTag("BtchId")]
    public IsoMax70Text? BatchIdentification { get; init; }

    /// <summary>
    /// Batch Identification List.
    /// </summary>
    [DisplayName("Batch Identification List")]
    [IsoXmlTag("BtchIdList")]
    public ValueList<IsoMax70Text> BatchIdentificationList { get; init; } = [];

    /// <summary>
    /// Batch Management Type.
    /// </summary>
    [DisplayName("Batch Management Type")]
    [IsoXmlTag("BtchMgmtTp")]
    public required BatchManagementType2Code BatchManagementType { get; init; }

    /// <summary>
    /// Checkpoint Identification.
    /// </summary>
    [DisplayName("Checkpoint Identification")]
    [IsoXmlTag("ChckptId")]
    public IsoMax70Text? CheckpointIdentification { get; init; }

    /// <summary>
    /// Collection Checksum.
    /// </summary>
    [DisplayName("Collection Checksum")]
    [IsoXmlTag("ColltnChcksm")]
    public IsoMax35Binary? CollectionChecksum { get; init; }

    /// <summary>
    /// Collection Identification.
    /// </summary>
    [DisplayName("Collection Identification")]
    [IsoXmlTag("ColltnId")]
    public IsoMax70Text? CollectionIdentification { get; init; }

    /// <summary>
    /// Collection Identification List.
    /// </summary>
    [DisplayName("Collection Identification List")]
    [IsoXmlTag("ColltnIdList")]
    public ValueList<IsoMax70Text> CollectionIdentificationList { get; init; } = [];

    /// <summary>
    /// Collection Size.
    /// </summary>
    [DisplayName("Collection Size")]
    [IsoXmlTag("ColltnSz")]
    public IsoNumber? CollectionSize { get; init; }

    /// <summary>
    /// Continuation.
    /// </summary>
    [DisplayName("Continuation")]
    [IsoXmlTag("Conttn")]
    public IsoTrueFalseIndicator? Continuation { get; init; }

    /// <summary>
    /// Correction.
    /// </summary>
    [DisplayName("Correction")]
    [IsoXmlTag("Crrctn")]
    public CorrectionIdentification1? Correction { get; init; }

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification286? Destination { get; init; }

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
    /// Messages Before Acknowledgement.
    /// </summary>
    [DisplayName("Messages Before Acknowledgement")]
    [IsoXmlTag("MsgsBfrAck")]
    public IsoNumber? MessagesBeforeAcknowledgement { get; init; }

    /// <summary>
    /// Message Sequence Number.
    /// </summary>
    [DisplayName("Message Sequence Number")]
    [IsoXmlTag("MsgSeqNb")]
    public IsoMax15NumericText? MessageSequenceNumber { get; init; }

    /// <summary>
    /// Number Of Batches In Collection.
    /// </summary>
    [DisplayName("Number Of Batches In Collection")]
    [IsoXmlTag("NbOfBtchsInColltn")]
    public IsoNumber? NumberOfBatchesInCollection { get; init; }

    /// <summary>
    /// Number Of Messages.
    /// </summary>
    [DisplayName("Number Of Messages")]
    [IsoXmlTag("NbOfMsgs")]
    public IsoNumber? NumberOfMessages { get; init; }

    /// <summary>
    /// Original Batch Identification.
    /// </summary>
    [DisplayName("Original Batch Identification")]
    [IsoXmlTag("OrgnlBtchId")]
    public IsoMax70Text? OriginalBatchIdentification { get; init; }

    /// <summary>
    /// Original Collection Identification.
    /// </summary>
    [DisplayName("Original Collection Identification")]
    [IsoXmlTag("OrgnlColltnId")]
    public IsoMax70Text? OriginalCollectionIdentification { get; init; }

    /// <summary>
    /// Original Response Code.
    /// </summary>
    [DisplayName("Original Response Code")]
    [IsoXmlTag("OrgnlRspnCd")]
    public ISO8583ResponseCode? OriginalResponseCode { get; init; }

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification286? Originator { get; init; }

    /// <summary>
    /// Other Batch Management Type.
    /// </summary>
    [DisplayName("Other Batch Management Type")]
    [IsoXmlTag("OthrBtchMgmtTp")]
    public IsoMax35Text? OtherBatchManagementType { get; init; }

    /// <summary>
    /// Positive Acknowledgement.
    /// </summary>
    [DisplayName("Positive Acknowledgement")]
    [IsoXmlTag("PostvAck")]
    public IsoTrueFalseIndicator? PositiveAcknowledgement { get; init; }

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
    /// Remaining Messages In Collection.
    /// </summary>
    [DisplayName("Remaining Messages In Collection")]
    [IsoXmlTag("RmngMsgsInColltn")]
    public IsoNumber? RemainingMessagesInCollection { get; init; }

    /// <summary>
    /// Request Acknowledgement.
    /// </summary>
    [DisplayName("Request Acknowledgement")]
    [IsoXmlTag("ReqAck")]
    public IsoTrueFalseIndicator? RequestAcknowledgement { get; init; }

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
    public IsoMax12NumericText? SystemTraceAuditNumber { get; init; }

    /// <summary>
    /// Transmission Date Time.
    /// </summary>
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    public IsoISODateTime? TransmissionDateTime { get; init; }
}

// Since BatchManagementInitiationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BatchManagementInitiationV03.
