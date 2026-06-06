// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities settlement transaction.
/// </summary>
[IsoId("bc4e3872-28fe-433d-91e3-4213f3947bec")]
[DisplayName("Transaction Details177")]
public record TransactionDetails177
{
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b01")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b02")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b03")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b04")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b05")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b06")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b07")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b08")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b09")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b10")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b11")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b12")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b13")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b14")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b15")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b16")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b17")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity51Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument to be released.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b18")]
    [DisplayName("Partially Released Quantity")]
    [IsoXmlTag("PrtlyRlsdQty")]
    public Quantity51Choice_? PartiallyReleasedQuantity { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b19")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection51? SettlementAmount { get; init; }

    /// <summary>
    /// Amount of digital asset that is to be/was posted to the account as a means of payment.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b20")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public DigitalPaymentSettlement2? DigitalPaymentSettlement { get; init; }

    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b21")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; }

    /// <summary>
    /// Date/time at which the sender expects settlement.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b22")]
    [DisplayName("Expected Settlement Date")]
    [IsoXmlTag("XpctdSttlmDt")]
    public DateAndDateTime2Choice_? ExpectedSettlementDate { get; init; }

    /// <summary>
    /// For against payment transactions, the value date/time at which the sender expects the settlement amount to be credited or debited.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b23")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public DateAndDateTime2Choice_? ExpectedValueDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b24")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate19Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b25")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is acknowledged.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b26")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    /// <summary>
    /// Time stamp on when the transaction is matched.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b27")]
    [DisplayName("Matched Status Time Stamp")]
    [IsoXmlTag("MtchdStsTmStmp")]
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b28")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b29")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b30")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public required SettlementDetails222 SettlementParameters { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b31")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties125? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b32")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties125? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b33")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification149? Investor { get; init; }

    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b34")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentification136? QualifiedForeignIntermediary { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("bc4e3872-28fe-433d-91e3-4213f3947b35")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
