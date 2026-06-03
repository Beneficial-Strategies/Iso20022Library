// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus17Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus17Choice.NoSpecifiedReason), nameof(FailingStatus17Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus17Choice.Reason), nameof(FailingStatus17Choice.Reason))]
    [IsoId("_0gHWgeSkEe-qVZLXW4RRBw")]
    [DisplayName("Failing Status 17 Choice")]
    public abstract record FailingStatus17Choice_ { }
}
