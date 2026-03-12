// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus11Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus11Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus11Choice.NoSpecifiedReason),nameof(FailingStatus11Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus11Choice.Reason),nameof(FailingStatus11Choice.Reason))]
    [IsoId("_5SGOr5NLEeWGlc8L7oPDIg")]
    [DisplayName("Failing Status 11 Choice")]
    public abstract partial record FailingStatus11Choice_
    {
    }
}
