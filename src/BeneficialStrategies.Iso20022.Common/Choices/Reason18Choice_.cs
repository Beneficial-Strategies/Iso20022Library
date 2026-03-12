// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(Reason18Choice.Reason))]
    [KnownType(typeof(Reason18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(Reason18Choice.Reason),nameof(Reason18Choice.Reason))]
    [JsonDerivedType(typeof(Reason18Choice.NoSpecifiedReason),nameof(Reason18Choice.NoSpecifiedReason))]
    [IsoId("_zII1AeLtEeWOD7aAy2fAcA")]
    [DisplayName("Reason 18 Choice")]
    public abstract partial record Reason18Choice_
    {
    }
}
