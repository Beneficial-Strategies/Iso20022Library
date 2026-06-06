// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
[IsoId("d6c104dd-9c91-45b5-97c9-5b452838f30e")]
[DisplayName("Transaction164")]
public record Transaction164
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("01e44d82-579a-4447-b1b2-77cfcee0d9d2")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("be854f6d-f3a7-4180-9851-740b9aa84175")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("8cd4fb67-e20b-4f14-963c-c3a5b08b190a")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("c689942b-cc48-4229-a11b-d208f4961071")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
    /// </summary>
    [IsoId("330dfe69-8164-4554-811d-7da0c33a716e")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("8b29d3de-c2f9-4159-923c-91fddaaaab3c")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("e569398c-5741-4720-a2a6-89ec3cfccc9f")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("721907f0-62a6-43a1-a7a4-84054a0c3ab6")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("e1cefdcf-06a9-44a8-a1f4-6cc273278d07")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("e5594ebc-939c-4600-ba4f-a59bfc122483")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    [IsoId("3cb7664b-d8a5-42e6-b12c-fa81fc99c25c")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [IsoId("94a56fdc-9d4c-451c-8368-07f1e0344eac")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [IsoId("7a4c6f69-fa65-42d9-9c96-0784890578f0")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    [IsoId("88b95ad8-8b90-4e7e-833f-b079789f3efd")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("1f2419fe-620a-47b1-99ff-86f17f21effb")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails185? TransactionDetails { get; init; }

    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("7c8bd021-b82c-47a8-baae-0600de276884")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public ValueList<Status43Choice_> StatusAndReason { get; init; } = [];
}
