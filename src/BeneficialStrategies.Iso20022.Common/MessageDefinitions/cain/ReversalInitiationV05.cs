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
/// This record is an implementation of the cain.005.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_n_fC4ROIEfC1ZfCQz0xB3g")]
[DisplayName("Reversal Initiation V05")]
public record ReversalInitiationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.005.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.005.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_n_fC4xOIEfC1ZfCQz0xB3g")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header72 Header { get; init; }

    /// <summary>
    /// Contains the key data elements of the transaction.
    /// </summary>
    [IsoId("_n_fC5ROIEfC1ZfCQz0xB3g")]
    [DisplayName("Transaction Characteristics")]
    [IsoXmlTag("TxChrtcs")]
    public required TransactionCharacteristics5 TransactionCharacteristics { get; init; }

    /// <summary>
    /// Information related to the originator.
    /// </summary>
    [IsoId("_n_fC5xOIEfC1ZfCQz0xB3g")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public OriginatorData2? Originator { get; init; }

    /// <summary>
    /// Information related to the acquirer.
    /// </summary>
    [IsoId("_n_fC6ROIEfC1ZfCQz0xB3g")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required AcquirerData1 Acquirer { get; init; }

    /// <summary>
    /// Information related to the sender.
    /// </summary>
    [IsoId("_n_fC8ROIEfC1ZfCQz0xB3g")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public SenderData1? Sender { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_n_fC8xOIEfC1ZfCQz0xB3g")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData16? Card { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_n_fC9ROIEfC1ZfCQz0xB3g")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails4? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_n_fC9xOIEfC1ZfCQz0xB3g")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails4? AccountTo { get; init; }

    /// <summary>
    /// Information related to the receiver.
    /// </summary>
    [IsoId("_n_fC-ROIEfC1ZfCQz0xB3g")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public ReceiverData1? Receiver { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_n_fDAROIEfC1ZfCQz0xB3g")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IssuerData1? Issuer { get; init; }

    /// <summary>
    /// Information related to the destination.
    /// </summary>
    [IsoId("_n_fDAxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public DestinationData1? Destination { get; init; }

    /// <summary>
    /// Programme, network, or brand processes the transaction.
    /// </summary>
    [IsoId("_n_fDBROIEfC1ZfCQz0xB3g")]
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ProgrammeMode7? Programme { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_n_fDDROIEfC1ZfCQz0xB3g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification58 TransactionIdentification { get; init; }

    /// <summary>
    /// Date and Time of currency conversion.
    /// </summary>
    [IsoId("_n_fDDxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Conversion Date Time")]
    [IsoXmlTag("ConvsDtTm")]
    public DateTime2? ConversionDateTime { get; init; }

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_n_fDEROIEfC1ZfCQz0xB3g")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts5 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_n_fDExOIEfC1ZfCQz0xB3g")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts5> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Taxes applying to the good or item.
    /// </summary>
    [IsoId("_VZDYgUrZEfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Data elements contained in the original message.
    /// </summary>
    [IsoId("_n_fDGxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Original Data Elements")]
    [IsoXmlTag("OrgnlDataElmts")]
    public OriginalDataElements6? OriginalDataElements { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_n_fDKROIEfC1ZfCQz0xB3g")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public AcceptorData1? Acceptor { get; init; }

    /// <summary>
    /// Information related to the transactior who provides technical payment solutions for acceptor and originator to conduct transactions.
    /// </summary>
    [IsoId("_00lJxWvfEfCyxsm1jzUNug")]
    [DisplayName("Transactor")]
    [IsoXmlTag("Txtr")]
    public TransactorData1? Transactor { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_n_fDKxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal10? Terminal { get; init; }

    /// <summary>
    /// Context of the reversal transaction.
    /// </summary>
    [IsoId("_n_fDLROIEfC1ZfCQz0xB3g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context25? Context { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// </summary>
    [IsoId("_n_fDLxOIEfC1ZfCQz0xB3g")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public Max10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contain information related to authentication.
    /// </summary>
    [IsoId("_00lJyGvfEfCyxsm1jzUNug")]
    [DisplayName("Authentication Data")]
    [IsoXmlTag("AuthntcnData")]
    public CardAuthenticationData1? AuthenticationData { get; init; }

    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_n_fDMROIEfC1ZfCQz0xB3g")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PayerData1? Payer { get; init; }

    /// <summary>
    /// The party receiving funds.
    /// </summary>
    [IsoId("_n_fDMxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PayeeData1? Payee { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_n_fDNROIEfC1ZfCQz0xB3g")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token5? Token { get; init; }

    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_-p0xETJ6EfCLfeKcVPKw8g")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice6? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_n_fDNxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet4? Wallet { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_Zn-JoTTYEfCLfeKcVPKw8g")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public ValueList<Cardholder23> Cardholder { get; init; } = [];

    /// <summary>
    /// Contain validation result and/or data to be validated.
    /// </summary>
    [IsoId("_gChCsRRAEfC_aaedwHHlmw")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification8> Verification { get; init; } = [];

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_n_fDOROIEfC1ZfCQz0xB3g")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SimpleValueList<ATICALaxProcessing> SpecialProgrammeQualification { get; init; } = [];

    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_mQC4Ya3BEfCKbLfqFyM0kg")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public Instalment8? Instalment { get; init; }

    /// <summary>
    /// Detail information of the recurring payment.
    /// </summary>
    [IsoId("_tySVwV54EfCoP_h9uwd39Q")]
    [DisplayName("Recurring Payment")]
    [IsoXmlTag("RcrngPmt")]
    public RecurringPaymentData1? RecurringPayment { get; init; }

    /// <summary>
    /// Balance of the account involved in the card transaction.
    /// </summary>
    [IsoId("_n_fDOxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public ValueList<AccountBalance4> AccountBalance { get; init; } = [];

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_n_fDPROIEfC1ZfCQz0xB3g")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService3> AdditionalService { get; init; } = [];

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_n_fDPxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService4? FundsServices { get; init; }

    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_n_fDQROIEfC1ZfCQz0xB3g")]
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails4> DepositDetails { get; init; } = [];

    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    [IsoId("_n_fDQxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_n_fDRROIEfC1ZfCQz0xB3g")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService7? SettlementService { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_n_fDRxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee4> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_n_fDSROIEfC1ZfCQz0xB3g")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation5? Reconciliation { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_n_fDSxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult28? ProcessingResult { get; init; }

    /// <summary>
    /// Contain benefit supporting data.
    /// </summary>
    [IsoId("_00lJyWvfEfCyxsm1jzUNug")]
    [DisplayName("Benefits")]
    [IsoXmlTag("Bnfts")]
    public ValueList<BenefitSupportingData1> Benefits { get; init; } = [];

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_n_fDTxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<EncryptedData2> ProtectedData { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_WqV0skYMEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<ATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_WqV0s0YMEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<ATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_n_fDUxOIEfC1ZfCQz0xB3g")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType41? SecurityTrailer { get; init; }
}
