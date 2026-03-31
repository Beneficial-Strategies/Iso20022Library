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
/// This record is an implementation of the caad.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_SoTSEY7ZEe6S0_1AaJzQCA")]
[DisplayName("Administrative Initiation V02")]
public record AdministrativeInitiationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.008.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdmstvInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.008.001.02";

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
    /// Additional Service.
    /// </summary>
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Administrative Type.
    /// </summary>
    [DisplayName("Administrative Type")]
    [IsoXmlTag("AdmstvTp")]
    public required AdministrativeType1Code AdministrativeType { get; init; }

    /// <summary>
    /// Alternate Message Reason.
    /// </summary>
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public ValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData11? Card { get; init; }

    /// <summary>
    /// Cardholder.
    /// </summary>
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder22? Cardholder { get; init; }

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context19 Context { get; init; }

    /// <summary>
    /// Conversion Date Time.
    /// </summary>
    [DisplayName("Conversion Date Time")]
    [IsoXmlTag("ConvsDtTm")]
    public DateTime2? ConversionDateTime { get; init; }

    /// <summary>
    /// Customer.
    /// </summary>
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer4? Customer { get; init; }

    /// <summary>
    /// Customer Device.
    /// </summary>
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice5? CustomerDevice { get; init; }

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification286? Destination { get; init; }

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public ValueList<ExchangeRateInformation5> ExchangeRate { get; init; } = [];

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header71 Header { get; init; }

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Instalment.
    /// </summary>
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public Instalment6? Instalment { get; init; }

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
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData17> LocalData { get; init; } = [];

    /// <summary>
    /// Message Reason.
    /// </summary>
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Original Transaction.
    /// </summary>
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public ValueList<OriginalTransaction3> OriginalTransaction { get; init; } = [];

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification286? Originator { get; init; }

    /// <summary>
    /// Other Administrative Type.
    /// </summary>
    [DisplayName("Other Administrative Type")]
    [IsoXmlTag("OthrAdmstvTp")]
    public IsoMax35Text? OtherAdministrativeType { get; init; }

    /// <summary>
    /// Payee.
    /// </summary>
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification287? Payee { get; init; }

    /// <summary>
    /// Payer.
    /// </summary>
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification287? Payer { get; init; }

    /// <summary>
    /// POI Component.
    /// </summary>
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent16> POIComponent { get; init; } = [];

    /// <summary>
    /// Processing Result.
    /// </summary>
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult27? ProcessingResult { get; init; }

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ProgrammeMode4? Programme { get; init; }

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
    /// Risk.
    /// </summary>
    [DisplayName("Risk")]
    [IsoXmlTag("Rsk")]
    public ValueList<RiskContext3> Risk { get; init; } = [];

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
    public SettlementService5? SettlementService { get; init; }

    /// <summary>
    /// Special Programme Qualification.
    /// </summary>
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification2> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Terminal.
    /// </summary>
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal7? Terminal { get; init; }

    /// <summary>
    /// Text Message.
    /// </summary>
    [DisplayName("Text Message")]
    [IsoXmlTag("TxtMsg")]
    public IsoMax20KText? TextMessage { get; init; }

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
    public TransactionIdentification56? TransactionIdentification { get; init; }

    /// <summary>
    /// Verification.
    /// </summary>
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification6> Verification { get; init; } = [];

    /// <summary>
    /// Wallet.
    /// </summary>
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet3? Wallet { get; init; }
}

// Since AdministrativeInitiationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AdministrativeInitiationV02.
