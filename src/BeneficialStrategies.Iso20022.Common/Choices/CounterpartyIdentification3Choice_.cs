// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the reporting agent counterparty.
    /// </summary>
    [KnownType(typeof(CounterpartyIdentification3Choice.LEI))]
    [KnownType(typeof(CounterpartyIdentification3Choice.SectorAndLocation))]
    [KnownType(typeof(CounterpartyIdentification3Choice.NameAndLocation))]
    [JsonDerivedType(typeof(CounterpartyIdentification3Choice.LEI),nameof(CounterpartyIdentification3Choice.LEI))]
    [JsonDerivedType(typeof(CounterpartyIdentification3Choice.SectorAndLocation),nameof(CounterpartyIdentification3Choice.SectorAndLocation))]
    [JsonDerivedType(typeof(CounterpartyIdentification3Choice.NameAndLocation),nameof(CounterpartyIdentification3Choice.NameAndLocation))]
    [IsoId("_Zo-9QcEcEea7jLfvGi1PDw")]
    [DisplayName("Counterparty Identification 3 Choice")]
    public abstract partial record CounterpartyIdentification3Choice_
    {
    }
}
