// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the statement frequency.
    /// </summary>
    [KnownType(typeof(StatementFrequencyReason1Choice.Code))]
    [KnownType(typeof(StatementFrequencyReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(StatementFrequencyReason1Choice.Code),
        nameof(StatementFrequencyReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(StatementFrequencyReason1Choice.Proprietary),
        nameof(StatementFrequencyReason1Choice.Proprietary)
    )]
    [IsoId("_gGvAoxc_EeK5g-3oYI0_9Q")]
    [DisplayName("Statement Frequency Reason 1 Choice")]
    public abstract record StatementFrequencyReason1Choice_ { }
}
