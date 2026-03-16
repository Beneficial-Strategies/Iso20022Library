// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Failing Status15Choice.
    /// </summary>
    [KnownType(typeof(FailingStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus15Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus15Choice.NoSpecifiedReason),nameof(FailingStatus15Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus15Choice.Reason),nameof(FailingStatus15Choice.Reason))]
    [IsoId("_8p4XMYcTEe-FecylWsA1vA")]
    [DisplayName("Failing Status15Choice")]
    public abstract partial record FailingStatus15Choice_
    {
    }
}
