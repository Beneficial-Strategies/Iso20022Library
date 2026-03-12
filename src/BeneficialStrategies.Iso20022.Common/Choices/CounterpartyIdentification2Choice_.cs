// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the identification of the reporting agent counterparty.
    /// </summary>
    [KnownType(typeof(CounterpartyIdentification2Choice.LEI))]
    [KnownType(typeof(CounterpartyIdentification2Choice.Other))]
    [JsonDerivedType(typeof(CounterpartyIdentification2Choice.LEI),nameof(CounterpartyIdentification2Choice.LEI))]
    [JsonDerivedType(typeof(CounterpartyIdentification2Choice.Other),nameof(CounterpartyIdentification2Choice.Other))]
    [IsoId("_QmCKwXvSEeWrWYBng3OpVw")]
    [DisplayName("Counterparty Identification 2 Choice")]
    public abstract partial record CounterpartyIdentification2Choice_
    {
    }
}
