// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature of the reporting counterparty&apos;s company activities.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature4Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature4Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature4Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature4Choice.Other))]
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.FinancialInstitution),nameof(CounterpartyTradeNature4Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature4Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.CentralCounterParty),nameof(CounterpartyTradeNature4Choice.CentralCounterParty))]
    [JsonDerivedType(typeof(CounterpartyTradeNature4Choice.Other),nameof(CounterpartyTradeNature4Choice.Other))]
    [IsoId("_6UemybsAEea-m5tPqiasmQ")]
    [DisplayName("Counterparty Trade Nature 4 Choice")]
    public abstract partial record CounterpartyTradeNature4Choice_
    {
    }
}
