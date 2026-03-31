// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cash purpose or a securities market identifier.
    /// </summary>
    [KnownType(
        typeof(MarketIdentificationOrCashPurpose1Choice.SettlementInstructionMarketIdentification)
    )]
    [KnownType(typeof(MarketIdentificationOrCashPurpose1Choice.CashSSIPurpose))]
    [JsonDerivedType(
        typeof(MarketIdentificationOrCashPurpose1Choice.SettlementInstructionMarketIdentification),
        nameof(MarketIdentificationOrCashPurpose1Choice.SettlementInstructionMarketIdentification)
    )]
    [JsonDerivedType(
        typeof(MarketIdentificationOrCashPurpose1Choice.CashSSIPurpose),
        nameof(MarketIdentificationOrCashPurpose1Choice.CashSSIPurpose)
    )]
    [IsoId("_Lc9dQEiNEeOdL6nMHefDgg")]
    [DisplayName("Market Identification Or Cash Purpose 1 Choice")]
    public abstract record MarketIdentificationOrCashPurpose1Choice_ { }
}
