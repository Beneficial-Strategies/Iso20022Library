// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus14Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus14Choice.NoSpecifiedReason),nameof(FailingStatus14Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus14Choice.Reason),nameof(FailingStatus14Choice.Reason))]
    [IsoId("_f99yAzi8Eeydid5dcNPKvg")]
    [DisplayName("Failing Status 14 Choice")]
    public abstract partial record FailingStatus14Choice_
    {
    }
}
