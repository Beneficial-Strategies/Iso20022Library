// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_87zZoQNrEfG_3cM8uyJ20w")]
[DisplayName("Transaction169")]
public record Transaction169
{
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_8-YMgwNrEfG_3cM8uyJ20w")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_8-YMhQNrEfG_3cM8uyJ20w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_8-YMhwNrEfG_3cM8uyJ20w")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public StatusAndReason52? StatusAndReason { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_8-YMjwNrEfG_3cM8uyJ20w")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_8-ZapQNrEfG_3cM8uyJ20w")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_8-ZarQNrEfG_3cM8uyJ20w")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_8-ZatQNrEfG_3cM8uyJ20w")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction as assigned by the processor.
    /// </summary>
    [IsoId("_8-ZatwNrEfG_3cM8uyJ20w")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_8-ZauQNrEfG_3cM8uyJ20w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_lDxI4QjOEfGIV7JKjdGBTg")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_8-aBsQNrEfG_3cM8uyJ20w")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_8-aoxQNrEfG_3cM8uyJ20w")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_8-aozQNrEfG_3cM8uyJ20w")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("_8-ao1QNrEfG_3cM8uyJ20w")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [IsoId("_8-ao1wNrEfG_3cM8uyJ20w")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    [IsoId("_8-ao3wNrEfG_3cM8uyJ20w")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("_8-ao4QNrEfG_3cM8uyJ20w")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Identifies additional details of the transaction.
    /// </summary>
    [IsoId("_8-ao4wNrEfG_3cM8uyJ20w")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails187? TransactionDetails { get; init; }
}
