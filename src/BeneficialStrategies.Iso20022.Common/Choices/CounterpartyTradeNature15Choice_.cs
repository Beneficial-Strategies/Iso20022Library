// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature of the counterparty&apos;s company activities.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature15Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature15Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature15Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature15Choice.Other))]
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.FinancialInstitution),nameof(CounterpartyTradeNature15Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature15Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.CentralCounterParty),nameof(CounterpartyTradeNature15Choice.CentralCounterParty))]
    [JsonDerivedType(typeof(CounterpartyTradeNature15Choice.Other),nameof(CounterpartyTradeNature15Choice.Other))]
    [IsoId("_1y9eQQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Counterparty Trade Nature 15 Choice")]
    public abstract partial record CounterpartyTradeNature15Choice_
    {
    }
}
