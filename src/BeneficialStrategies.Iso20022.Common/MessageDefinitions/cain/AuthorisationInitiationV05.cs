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
/// This record is an implementation of the cain.001.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_l2kEAROHEfC1ZfCQz0xB3g")]
[DisplayName("Authorisation Initiation V05")]
public record AuthorisationInitiationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.001.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AuthstnInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.001.001.05";

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
    public AcceptorData1? Acceptor { get; init; }

    /// <summary>
    /// Account Balance.
    /// </summary>
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public ValueList<AccountBalance4> AccountBalance { get; init; } = [];

    /// <summary>
    /// Account From.
    /// </summary>
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails4? AccountFrom { get; init; }

    /// <summary>
    /// Account To.
    /// </summary>
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails4? AccountTo { get; init; }

    /// <summary>
    /// Acquirer.
    /// </summary>
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required AcquirerData1 Acquirer { get; init; }

    /// <summary>
    /// Additional Amount.
    /// </summary>
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts5> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Additional Fee.
    /// </summary>
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee4> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Additional Service.
    /// </summary>
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService3> AdditionalService { get; init; } = [];

    /// <summary>
    /// Authentication Data.
    /// </summary>
    [DisplayName("Authentication Data")]
    [IsoXmlTag("AuthntcnData")]
    public CardAuthenticationData1? AuthenticationData { get; init; }

    /// <summary>
    /// Benefits.
    /// </summary>
    [DisplayName("Benefits")]
    [IsoXmlTag("Bnfts")]
    public ValueList<BenefitSupportingData1> Benefits { get; init; } = [];

    /// <summary>
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData16? Card { get; init; }

    /// <summary>
    /// Cardholder.
    /// </summary>
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public ValueList<Cardholder23> Cardholder { get; init; } = [];

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context26 Context { get; init; }

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
    public CustomerDevice6? CustomerDevice { get; init; }

    /// <summary>
    /// Deposit Details.
    /// </summary>
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails4> DepositDetails { get; init; } = [];

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public DestinationData1? Destination { get; init; }

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public ValueList<CardExchangeRate1> ExchangeRate { get; init; } = [];

    /// <summary>
    /// Funds Services.
    /// </summary>
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService4? FundsServices { get; init; }

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header72 Header { get; init; }

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
    public Instalment8? Instalment { get; init; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IssuerData1? Issuer { get; init; }

    /// <summary>
    /// Jurisdiction.
    /// </summary>
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// National Data.
    /// </summary>
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<ATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Original Data Elements.
    /// </summary>
    [DisplayName("Original Data Elements")]
    [IsoXmlTag("OrgnlDataElmts")]
    public OriginalDataElements6? OriginalDataElements { get; init; }

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public OriginatorData2? Originator { get; init; }

    /// <summary>
    /// Payee.
    /// </summary>
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PayeeData1? Payee { get; init; }

    /// <summary>
    /// Payer.
    /// </summary>
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PayerData1? Payer { get; init; }

    /// <summary>
    /// POI Component.
    /// </summary>
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent16> POIComponent { get; init; } = [];

    /// <summary>
    /// Private Data.
    /// </summary>
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<ATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Processing Result.
    /// </summary>
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult28? ProcessingResult { get; init; }

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ProgrammeMode7? Programme { get; init; }

    /// <summary>
    /// Promotion.
    /// </summary>
    [DisplayName("Promotion")]
    [IsoXmlTag("Prmtn")]
    public ValueList<PromotionData1> Promotion { get; init; } = [];

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
    /// Recurring Payment.
    /// </summary>
    [DisplayName("Recurring Payment")]
    [IsoXmlTag("RcrngPmt")]
    public RecurringPaymentData1? RecurringPayment { get; init; }

    /// <summary>
    /// Risk.
    /// </summary>
    [DisplayName("Risk")]
    [IsoXmlTag("Rsk")]
    public ValueList<RiskContext4> Risk { get; init; } = [];

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
    /// Special Programme Qualification.
    /// </summary>
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<ATICALaxProcessing> SpecialProgrammeQualification { get; init; } = [];

    /// <summary>
    /// Strong Customer Authentication.
    /// </summary>
    [DisplayName("Strong Customer Authentication")]
    [IsoXmlTag("StrngCstmrAuthntcn")]
    public StrongCustomerAuthentication2? StrongCustomerAuthentication { get; init; }

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Terminal.
    /// </summary>
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal10? Terminal { get; init; }

    /// <summary>
    /// Token.
    /// </summary>
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token5? Token { get; init; }

    /// <summary>
    /// Transaction Amounts.
    /// </summary>
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts5 TransactionAmounts { get; init; }

    /// <summary>
    /// Transaction Characteristics.
    /// </summary>
    [DisplayName("Transaction Characteristics")]
    [IsoXmlTag("TxChrtcs")]
    public required TransactionCharacteristics5 TransactionCharacteristics { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification58 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Specific Data.
    /// </summary>
    [DisplayName("Transaction Specific Data")]
    [IsoXmlTag("TxSpcfcData")]
    public TransactionSpecificData1? TransactionSpecificData { get; init; }

    /// <summary>
    /// Transactor.
    /// </summary>
    [DisplayName("Transactor")]
    [IsoXmlTag("Txtr")]
    public ValueList<TransactorData1> Transactor { get; init; } = [];

    /// <summary>
    /// Verification.
    /// </summary>
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification8> Verification { get; init; } = [];

    /// <summary>
    /// Wallet.
    /// </summary>
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet4? Wallet { get; init; }
}

// Since AuthorisationInitiationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AuthorisationInitiationV05.
