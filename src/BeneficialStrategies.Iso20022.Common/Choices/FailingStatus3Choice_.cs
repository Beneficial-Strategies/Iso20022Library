// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus3Choice.Reason))]
    [JsonDerivedType(
        typeof(FailingStatus3Choice.NoSpecifiedReason),
        nameof(FailingStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(FailingStatus3Choice.Reason), nameof(FailingStatus3Choice.Reason))]
    [IsoId("_vU-icf7qEeCvPoRGOxRobQ")]
    [DisplayName("Failing Status 3 Choice")]
    public abstract record FailingStatus3Choice_ { }
}
