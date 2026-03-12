// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus10Choice.Reason))]
    [JsonDerivedType(typeof(DeniedStatus10Choice.NoSpecifiedReason),nameof(DeniedStatus10Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DeniedStatus10Choice.Reason),nameof(DeniedStatus10Choice.Reason))]
    [IsoId("_gvJOR1hgEeS8HfHHd4stCA")]
    [DisplayName("Denied Status 10 Choice")]
    public abstract partial record DeniedStatus10Choice_
    {
    }
}
