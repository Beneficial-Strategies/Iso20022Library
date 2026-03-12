// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the statement frequency.
    /// </summary>
    [KnownType(typeof(StatementFrequencyReason2Choice.Code))]
    [KnownType(typeof(StatementFrequencyReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementFrequencyReason2Choice.Code),nameof(StatementFrequencyReason2Choice.Code))]
    [JsonDerivedType(typeof(StatementFrequencyReason2Choice.Proprietary),nameof(StatementFrequencyReason2Choice.Proprietary))]
    [IsoId("_rq-6sSDAEeWPMvNwVtiMsA")]
    [DisplayName("Statement Frequency Reason 2 Choice")]
    public abstract partial record StatementFrequencyReason2Choice_
    {
    }
}
