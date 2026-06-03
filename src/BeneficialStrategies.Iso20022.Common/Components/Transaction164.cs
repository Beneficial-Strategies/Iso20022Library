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
    [IsoId("01e44d82-579a-4447-b1b2-77cfcee0d9d2")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    [IsoId("be854f6d-f3a7-4180-9851-740b9aa84175")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    [IsoId("8cd4fb67-e20b-4f14-963c-c3a5b08b190a")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("c689942b-cc48-4229-a11b-d208f4961071")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("330dfe69-8164-4554-811d-7da0c33a716e")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("8b29d3de-c2f9-4159-923c-91fddaaaab3c")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("e569398c-5741-4720-a2a6-89ec3cfccc9f")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("721907f0-62a6-43a1-a7a4-84054a0c3ab6")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    [IsoId("e1cefdcf-06a9-44a8-a1f4-6cc273278d07")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    [IsoId("e5594ebc-939c-4600-ba4f-a59bfc122483")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    [IsoId("3cb7664b-d8a5-42e6-b12c-fa81fc99c25c")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    [IsoId("94a56fdc-9d4c-451c-8368-07f1e0344eac")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    [IsoId("7a4c6f69-fa65-42d9-9c96-0784890578f0")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    [IsoId("88b95ad8-8b90-4e7e-833f-b079789f3efd")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    [IsoId("1f2419fe-620a-47b1-99ff-86f17f21effb")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails185? TransactionDetails { get; init; }

    [IsoId("7c8bd021-b82c-47a8-baae-0600de276884")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public ValueList<Status43Choice> StatusAndReason { get; init; } = [];
}
