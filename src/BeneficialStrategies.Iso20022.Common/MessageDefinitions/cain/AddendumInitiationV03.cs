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
/// This record is an implementation of the cain.025.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_7dvQsX5VEe6YlIMyoxWMJA")]
[DisplayName("Addendum Initiation V03")]
public record AddendumInitiationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.025.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdddmInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.025.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Acceptor.
    /// </summary>
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification288? Acceptor { get; init; }

    /// <summary>
    /// Acquirer.
    /// </summary>
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification286 Acquirer { get; init; }

    /// <summary>
    /// Addendum Data.
    /// </summary>
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData6? AddendumData { get; init; }

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
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData14? Card { get; init; }

    /// <summary>
    /// Customer.
    /// </summary>
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer4? Customer { get; init; }

    /// <summary>
    /// Data Source.
    /// </summary>
    [DisplayName("Data Source")]
    [IsoXmlTag("DataSrc")]
    public IsoMax70Text? DataSource { get; init; }

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
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification286? Issuer { get; init; }

    /// <summary>
    /// Jurisdiction.
    /// </summary>
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Original Data Elements.
    /// </summary>
    [DisplayName("Original Data Elements")]
    [IsoXmlTag("OrgnlDataElmts")]
    public OriginalDataElements3? OriginalDataElements { get; init; }

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification286? Originator { get; init; }

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
    /// Token.
    /// </summary>
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }

    /// <summary>
    /// Transaction Description.
    /// </summary>
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification53 TransactionIdentification { get; init; }
}

// Since AddendumInitiationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AddendumInitiationV03.
