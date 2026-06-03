// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to an original transaction.
/// </summary>
[IsoId("_MXuoERNZEfC1ZfCQz0xB3g")]
[DisplayName("Original Transaction4")]
public record OriginalTransaction4
{
    /// <summary>
    /// Transaction characteristics of the original transaction.
    /// </summary>
    [IsoId("_Me61MRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Transaction Characteristics")]
    [IsoXmlTag("TxChrtcs")]
    public OriginalTransactionCharacteristics2? TransactionCharacteristics { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_Me61MxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public OriginatorData2? Originator { get; init; }

    /// <summary>
    /// Identification of the acquirer.
    /// </summary>
    [IsoId("_Me61NRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public AcquirerData1? Acquirer { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_Me61PRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public SenderData1? Sender { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_Me61PxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData17 Card { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_Me61QRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails4? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_Me61QxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails4? AccountTo { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// </summary>
    [IsoId("_Me61RRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public ReceiverData1? Receiver { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_Me61TRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IssuerData1? Issuer { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_Me61TxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public DestinationData1? Destination { get; init; }

    /// <summary>
    /// Programme, network, or brand processes the transaction.
    /// </summary>
    [IsoId("_Me61URNZEfC1ZfCQz0xB3g")]
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ProgrammeMode7? Programme { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Me61WRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification60? TransactionIdentification { get; init; }

    /// <summary>
    /// Date and Time of currency conversion.
    /// </summary>
    [IsoId("_Me61WxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Conversion Date Time")]
    [IsoXmlTag("ConvsDtTm")]
    public DateTime2? ConversionDateTime { get; init; }

    /// <summary>
    /// Further detailed information on the exchange rates that have been used in or are related to the transaction.
    /// </summary>
    [IsoId("_Me61XRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public ValueList<CardExchangeRate1> ExchangeRate { get; init; } = [];

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_Me61XxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public TransactionAmounts5? TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_Me61YRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts5> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_Me61aRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public AcceptorData3? Acceptor { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_Me61axNZEfC1ZfCQz0xB3g")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal13? Terminal { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the transactions.
    /// </summary>
    [IsoId("_Me61bRNZEfC1ZfCQz0xB3g")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent16> POIComponent { get; init; } = [];

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_Me61bxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context26? Context { get; init; }

    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_Me61cRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PayerData1? Payer { get; init; }

    /// <summary>
    /// The party receiving funds.
    /// </summary>
    [IsoId("_Me61cxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PayeeData1? Payee { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_Me61dRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token5? Token { get; init; }

    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_Me61dxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice6? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_Me61eRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet4? Wallet { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_Me61exNZEfC1ZfCQz0xB3g")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public ValueList<Cardholder23> Cardholder { get; init; } = [];

    /// <summary>
    /// Contain validation result and/or data to be validated.
    /// </summary>
    [IsoId("_Me61fRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification9> Verification { get; init; } = [];

    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_Me61fxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Risk")]
    [IsoXmlTag("Rsk")]
    public ValueList<RiskContext4> Risk { get; init; } = [];

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_Me61gRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SimpleValueList<IsoATICALaxProcessing> SpecialProgrammeQualification { get; init; } = [];

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_Me61gxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService3> AdditionalService { get; init; } = [];

    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    [IsoId("_Me61hRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService4? FundsServices { get; init; }

    /// <summary>
    /// Contains ATM deposit details.
    /// </summary>
    [IsoId("_Me61hxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails4> DepositDetails { get; init; } = [];

    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    [IsoId("_Me61iRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_Me61ixNZEfC1ZfCQz0xB3g")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService7? SettlementService { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_Me61jRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee4> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_Me61jxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation5? Reconciliation { get; init; }

    /// <summary>
    /// Information about the dispute.
    /// </summary>
    [IsoId("_Me61kRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public ValueList<DisputeData5> DisputeData { get; init; } = [];

    /// <summary>
    /// Additional information related to the dispute.
    /// </summary>
    [IsoId("_Me61kxNZEfC1ZfCQz0xB3g")]
    [DisplayName("Documentation")]
    [IsoXmlTag("Dcmnttn")]
    public ValueList<DisputeDocumentation2> Documentation { get; init; } = [];

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_Me61lRNZEfC1ZfCQz0xB3g")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult29? ProcessingResult { get; init; }
}
