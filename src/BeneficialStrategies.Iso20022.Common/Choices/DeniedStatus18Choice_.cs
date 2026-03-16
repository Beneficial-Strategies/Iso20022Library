// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus18Choice.Reason))]
    [JsonDerivedType(
        typeof(DeniedStatus18Choice.NoSpecifiedReason),
        nameof(DeniedStatus18Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(DeniedStatus18Choice.Reason), nameof(DeniedStatus18Choice.Reason))]
    [IsoId("_6BLiBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Denied Status 18 Choice")]
    public abstract record DeniedStatus18Choice_ { }
}
