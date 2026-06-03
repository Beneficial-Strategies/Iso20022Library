// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction type and identification information.
/// </summary>
[IsoId("_xaFbEagzEfCXwLUUylXgrQ")]
[DisplayName("Transaction Identifications55")]
public record TransactionIdentifications55
{
    [IsoId("_27vtYq2EEfCaaYGmz0prFg")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("_sTNBYa2EEfCaaYGmz0prFg")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("_xdAMM6gzEfCXwLUUylXgrQ")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    [IsoId("_xdAMO6gzEfCXwLUUylXgrQ")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    [IsoId("_xdAMQ6gzEfCXwLUUylXgrQ")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("_mVPNkagzEfCXwLUUylXgrQ")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("_xdAMS6gzEfCXwLUUylXgrQ")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("_xdAMTagzEfCXwLUUylXgrQ")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    [IsoId("_xdAMVagzEfCXwLUUylXgrQ")]
    [DisplayName("Netting Service Provider Identification")]
    [IsoXmlTag("NetgSvcPrvdrId")]
    public IsoMax35Text? NettingServiceProviderIdentification { get; init; }

    [IsoId("_xdAMV6gzEfCXwLUUylXgrQ")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    [IsoId("_xdAMW6gzEfCXwLUUylXgrQ")]
    [DisplayName("Related Transaction Identification")]
    [IsoXmlTag("RltdTxId")]
    public IsoMax35Text? RelatedTransactionIdentification { get; init; }
}
