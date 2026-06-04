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

namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.020.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_jlSk8ROHEfC1ZfCQz0xB3g")]
[DisplayName("Amendment V04")]
public record AmendmentV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.020.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "Amdmnt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.020.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Amended Data.
    /// </summary>
    [DisplayName("Amended Data")]
    [IsoXmlTag("AmddData")]
    public ValueList<ATICALaxProcessing> AmendedData { get; init; } = [];

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public DestinationData1? Destination { get; init; }

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header72 Header { get; init; }

    /// <summary>
    /// Jurisdiction.
    /// </summary>
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Message Amended.
    /// </summary>
    [DisplayName("Message Amended")]
    [IsoXmlTag("MsgAmdd")]
    public IsoMax100KBinary? MessageAmended { get; init; }

    /// <summary>
    /// National Data.
    /// </summary>
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<ATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Original Message.
    /// </summary>
    [DisplayName("Original Message")]
    [IsoXmlTag("OrgnlMsg")]
    public IsoMax100KBinary? OriginalMessage { get; init; }

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public OriginatorData2? Originator { get; init; }

    /// <summary>
    /// Private Data.
    /// </summary>
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<ATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ValueList<ProgrammeMode6> Programme { get; init; } = [];

    /// <summary>
    /// Protected Data.
    /// </summary>
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<EncryptedData2> ProtectedData { get; init; } = [];

    /// <summary>
    /// Receiver.
    /// </summary>
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public ReceiverData1? Receiver { get; init; }

    /// <summary>
    /// Reconciliation.
    /// </summary>
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation5? Reconciliation { get; init; }

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
    public SenderData1? Sender { get; init; }

    /// <summary>
    /// Settlement Service.
    /// </summary>
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService7? SettlementService { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification59 TransactionIdentification { get; init; }
}

// Since AmendmentV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendmentV04.
