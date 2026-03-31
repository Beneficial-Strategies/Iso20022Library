// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature of the reporting counterparty&apos;s company activities.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature9Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature9Choice.NonFinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature9Choice.CentralCounterParty))]
    [KnownType(typeof(CounterpartyTradeNature9Choice.Other))]
    [JsonDerivedType(
        typeof(CounterpartyTradeNature9Choice.FinancialInstitution),
        nameof(CounterpartyTradeNature9Choice.FinancialInstitution)
    )]
    [JsonDerivedType(
        typeof(CounterpartyTradeNature9Choice.NonFinancialInstitution),
        nameof(CounterpartyTradeNature9Choice.NonFinancialInstitution)
    )]
    [JsonDerivedType(
        typeof(CounterpartyTradeNature9Choice.CentralCounterParty),
        nameof(CounterpartyTradeNature9Choice.CentralCounterParty)
    )]
    [JsonDerivedType(
        typeof(CounterpartyTradeNature9Choice.Other),
        nameof(CounterpartyTradeNature9Choice.Other)
    )]
    [IsoId("_hsQpoT7KEeq0cMLnAmm7Lg")]
    [DisplayName("Counterparty Trade Nature 9 Choice")]
    public abstract record CounterpartyTradeNature9Choice_ { }
}
