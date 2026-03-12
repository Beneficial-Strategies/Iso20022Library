// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature of the reporting counterparty&apos;s company activities.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature5Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature5Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature5Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature5Choice.Other))]
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.FinancialInstitution),nameof(CounterpartyTradeNature5Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature5Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.CentralCounterParty),nameof(CounterpartyTradeNature5Choice.CentralCounterParty))]
    [JsonDerivedType(typeof(CounterpartyTradeNature5Choice.Other),nameof(CounterpartyTradeNature5Choice.Other))]
    [IsoId("_9qIT-bsAEea-m5tPqiasmQ")]
    [DisplayName("Counterparty Trade Nature 5 Choice")]
    public abstract partial record CounterpartyTradeNature5Choice_
    {
    }
}
