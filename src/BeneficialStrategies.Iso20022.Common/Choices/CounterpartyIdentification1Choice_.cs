// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the reporting agent counterparty.
    /// </summary>
    [KnownType(typeof(CounterpartyIdentification1Choice.LEI))]
    [KnownType(typeof(CounterpartyIdentification1Choice.Other))]
    [JsonDerivedType(typeof(CounterpartyIdentification1Choice.LEI),nameof(CounterpartyIdentification1Choice.LEI))]
    [JsonDerivedType(typeof(CounterpartyIdentification1Choice.Other),nameof(CounterpartyIdentification1Choice.Other))]
    [IsoId("_wlfJ0JfcEeSfnc-VXAEapg")]
    [DisplayName("Counterparty Identification 1 Choice")]
    public abstract partial record CounterpartyIdentification1Choice_
    {
    }
}
