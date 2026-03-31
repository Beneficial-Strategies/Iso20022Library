// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus9Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus9Choice.Reason))]
    [JsonDerivedType(
        typeof(FailingStatus9Choice.NoSpecifiedReason),
        nameof(FailingStatus9Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(FailingStatus9Choice.Reason), nameof(FailingStatus9Choice.Reason))]
    [IsoId("_17QAYTp5EeWVrPy0StzzSg")]
    [DisplayName("Failing Status 9 Choice")]
    public abstract record FailingStatus9Choice_ { }
}
