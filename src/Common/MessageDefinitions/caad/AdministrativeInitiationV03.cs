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
/// This record is an implementation of the caad.008.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_8QuIcRN9EfC1ZfCQz0xB3g")]
[DisplayName("Administrative Initiation V03")]
public partial record AdministrativeInitiationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.008.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdmstvInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.008.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header72 Header { get; init; }

    /// <summary>
    /// Administrative Type.
    /// </summary>
    [DisplayName("Administrative Type")]
    [IsoXmlTag("AdmstvTp")]
    public required AdministrativeType1Code AdministrativeType { get; init; }

    /// <summary>
    /// Message Reason.
    /// </summary>
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public ValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Alternate Message Reason.
    /// </summary>
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public ValueList<Max256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Text Message.
    /// </summary>
    [DisplayName("Text Message")]
    [IsoXmlTag("TxtMsg")]
    public Max20KText? TextMessage { get; init; }

    /// <summary>
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData17> LocalData { get; init; } = [];

    /// <summary>
    /// Transaction Description.
    /// </summary>
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public Max1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public OriginatorData2? Originator { get; init; }

    /// <summary>
    /// Acquirer.
    /// </summary>
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required AcquirerData1 Acquirer { get; init; }

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public SenderData1? Sender { get; init; }

    /// <summary>
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData16? Card { get; init; }

    /// <summary>
    /// Receiver.
    /// </summary>
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public ReceiverData1? Receiver { get; init; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IssuerData1? Issuer { get; init; }

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public DestinationData1? Destination { get; init; }

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ProgrammeMode7? Programme { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification61? TransactionIdentification { get; init; }

    /// <summary>
    /// Conversion Date Time.
    /// </summary>
    [DisplayName("Conversion Date Time")]
    [IsoXmlTag("ConvsDtTm")]
    public DateTime2? ConversionDateTime { get; init; }

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public ValueList<CardExchangeRate1> ExchangeRate { get; init; } = [];

    /// <summary>
    /// Acceptor.
    /// </summary>
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public AcceptorData1? Acceptor { get; init; }

    /// <summary>
    /// Transactor.
    /// </summary>
    [DisplayName("Transactor")]
    [IsoXmlTag("Txtr")]
    public TransactorData1? Transactor { get; init; }

    /// <summary>
    /// Terminal.
    /// </summary>
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal10? Terminal { get; init; }

    /// <summary>
    /// POI Component.
    /// </summary>
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent16> POIComponent { get; init; } = [];

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context26 Context { get; init; }

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public Max10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Authentication Data.
    /// </summary>
    [DisplayName("Authentication Data")]
    [IsoXmlTag("AuthntcnData")]
    public CardAuthenticationData1? AuthenticationData { get; init; }

    /// <summary>
    /// Payer.
    /// </summary>
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PayerData1? Payer { get; init; }

    /// <summary>
    /// Payee.
    /// </summary>
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PayeeData1? Payee { get; init; }

    /// <summary>
    /// Token.
    /// </summary>
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token5? Token { get; init; }

    /// <summary>
    /// Customer Device.
    /// </summary>
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice6? CustomerDevice { get; init; }

    /// <summary>
    /// Wallet.
    /// </summary>
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet4? Wallet { get; init; }

    /// <summary>
    /// Cardholder.
    /// </summary>
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public ValueList<Cardholder23> Cardholder { get; init; } = [];

    /// <summary>
    /// Customer.
    /// </summary>
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer4? Customer { get; init; }

    /// <summary>
    /// Verification.
    /// </summary>
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification8> Verification { get; init; } = [];

    /// <summary>
    /// Risk.
    /// </summary>
    [DisplayName("Risk")]
    [IsoXmlTag("Rsk")]
    public ValueList<RiskContext4> Risk { get; init; } = [];

    /// <summary>
    /// Special Programme Qualification.
    /// </summary>
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification2> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Instalment.
    /// </summary>
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public Instalment8? Instalment { get; init; }

    /// <summary>
    /// Additional Service.
    /// </summary>
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService3> AdditionalService { get; init; } = [];

    /// <summary>
    /// Jurisdiction.
    /// </summary>
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Settlement Service.
    /// </summary>
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService7? SettlementService { get; init; }

    /// <summary>
    /// Additional Fee.
    /// </summary>
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee4> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Reconciliation.
    /// </summary>
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation5? Reconciliation { get; init; }

    /// <summary>
    /// Processing Result.
    /// </summary>
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult28? ProcessingResult { get; init; }

    /// <summary>
    /// Original Transaction.
    /// </summary>
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public ValueList<OriginalTransaction4> OriginalTransaction { get; init; } = [];

    /// <summary>
    /// Protected Data.
    /// </summary>
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<EncryptedData2> ProtectedData { get; init; } = [];

    /// <summary>
    /// Private Data.
    /// </summary>
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<ATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// National Data.
    /// </summary>
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<ATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Security Trailer.
    /// </summary>
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType41? SecurityTrailer { get; init; }

    /// <summary>
    /// Recurring Payment.
    /// </summary>
    [DisplayName("Recurring Payment")]
    [IsoXmlTag("RcrngPmt")]
    public RecurringPaymentData1? RecurringPayment { get; init; }
}
