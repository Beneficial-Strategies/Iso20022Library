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
[IsoId("c3ceb0e5-2fc1-47a7-b209-39331e173d80")]
[DisplayName("Transaction165")]
public record Transaction165
{
    [IsoId("51ec5edb-e9d8-407c-9010-47ef8f6d717d")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    [IsoId("262b3a07-c0ac-47b2-a371-ee41bacc062e")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    [IsoId("e661038c-cb1f-40a6-99d5-38b4cb04a466")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("bb604285-4009-44f2-89fe-1b1a91f21794")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("8b1a445b-018b-4a48-9599-95a7350ed298")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("7fb6290c-7121-48cb-957f-c4edca5d26f2")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("5acd58db-58d7-4374-b07c-61edfc48608b")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("c3d3861a-3130-4c06-858a-7c226959bd03")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    [IsoId("bdaeba39-6a96-426d-a682-1d8fe5dda877")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    [IsoId("537ea65c-bfe9-4167-b325-0cdfd4dd7898")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    [IsoId("4da314c2-eeae-493a-a417-0159d946097e")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    [IsoId("317c2bc2-bd4a-47b7-b5c5-cccb6b9af3ff")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    [IsoId("28a6dcd8-b407-4ce5-8e5d-5526d16f1109")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    [IsoId("6422b09d-3b56-40f7-8fbc-96402062994d")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    [IsoId("ac8a0251-9e8e-49e0-998f-055fa0367f58")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    [IsoId("75f354f6-4e8b-4398-b0a1-bcb6947d0e2c")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    [IsoId("6e0fc0e9-e209-4a59-ac1c-753196f19c23")]
    [DisplayName("Account Owner Leg Identification")]
    [IsoXmlTag("AcctOwnrLegId")]
    public IsoMax35Text? AccountOwnerLegIdentification { get; init; }

    [IsoId("27f5973e-1b6d-45f8-8f80-8a8dbcc7a5cc")]
    [DisplayName("Account Servicer Leg Identification")]
    [IsoXmlTag("AcctSvcrLegId")]
    public IsoMax35Text? AccountServicerLegIdentification { get; init; }

    [IsoId("3f67014c-4485-4abb-8249-0668b8f216be")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails186? TransactionDetails { get; init; }

    [IsoId("5fd467e1-0c3a-465e-88f0-eeac7bf0aa6a")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
