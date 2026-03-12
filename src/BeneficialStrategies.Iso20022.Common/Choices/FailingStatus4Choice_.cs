// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus4Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus4Choice.NoSpecifiedReason),nameof(FailingStatus4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus4Choice.Reason),nameof(FailingStatus4Choice.Reason))]
    [IsoId("_Fe4Y0f7rEeCvPoRGOxRobQ")]
    [DisplayName("Failing Status 4 Choice")]
    public abstract partial record FailingStatus4Choice_
    {
    }
}
