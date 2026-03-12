// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature of the company activities of the reporting counterparty.
    /// </summary>
    [KnownType(typeof(CounterpartyTradeNature7Choice.FinancialInstitution))]
    [KnownType(typeof(CounterpartyTradeNature7Choice.NonFinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature7Choice.FinancialInstitution),nameof(CounterpartyTradeNature7Choice.FinancialInstitution))]
    [JsonDerivedType(typeof(CounterpartyTradeNature7Choice.NonFinancialInstitution),nameof(CounterpartyTradeNature7Choice.NonFinancialInstitution))]
    [IsoId("_-N5Qman9EemdLtwzt4CWxg")]
    [DisplayName("Counterparty Trade Nature 7 Choice")]
    public abstract partial record CounterpartyTradeNature7Choice_
    {
    }
}
