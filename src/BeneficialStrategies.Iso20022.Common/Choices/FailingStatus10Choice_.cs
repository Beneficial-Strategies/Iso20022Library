// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus10Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus10Choice.NoSpecifiedReason),nameof(FailingStatus10Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus10Choice.Reason),nameof(FailingStatus10Choice.Reason))]
    [IsoId("_3CuZQTqOEeWyoP0PbocV1Q")]
    [DisplayName("Failing Status 10 Choice")]
    public abstract partial record FailingStatus10Choice_
    {
    }
}
