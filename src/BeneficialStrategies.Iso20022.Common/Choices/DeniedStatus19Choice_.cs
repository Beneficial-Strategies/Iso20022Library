// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus19Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus19Choice.Reason))]
    [JsonDerivedType(typeof(DeniedStatus19Choice.NoSpecifiedReason),nameof(DeniedStatus19Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DeniedStatus19Choice.Reason),nameof(DeniedStatus19Choice.Reason))]
    [IsoId("_6GXkLZNLEeWGlc8L7oPDIg")]
    [DisplayName("Denied Status 19 Choice")]
    public abstract partial record DeniedStatus19Choice_
    {
    }
}
