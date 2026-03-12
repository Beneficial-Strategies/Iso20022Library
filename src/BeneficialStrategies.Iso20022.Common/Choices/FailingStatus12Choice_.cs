// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus12Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus12Choice.NoSpecifiedReason),nameof(FailingStatus12Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus12Choice.Reason),nameof(FailingStatus12Choice.Reason))]
    [IsoId("_6BKT-ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Failing Status 12 Choice")]
    public abstract partial record FailingStatus12Choice_
    {
    }
}
