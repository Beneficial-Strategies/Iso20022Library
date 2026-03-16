// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the relationship type between parties to the transaction.
    /// </summary>
    [KnownType(typeof(TradeCounterpartyRelationship1Choice.Code))]
    [KnownType(typeof(TradeCounterpartyRelationship1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradeCounterpartyRelationship1Choice.Code),
        nameof(TradeCounterpartyRelationship1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradeCounterpartyRelationship1Choice.Proprietary),
        nameof(TradeCounterpartyRelationship1Choice.Proprietary)
    )]
    [IsoId("_n_k54Cb_Ee2BYL6XeAmCWw")]
    [DisplayName("Trade Counterparty Relationship 1 Choice")]
    public abstract record TradeCounterpartyRelationship1Choice_ { }
}
