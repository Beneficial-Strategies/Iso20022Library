// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus17Choice.Reason))]
    [JsonDerivedType(typeof(DeniedStatus17Choice.NoSpecifiedReason),nameof(DeniedStatus17Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DeniedStatus17Choice.Reason),nameof(DeniedStatus17Choice.Reason))]
    [IsoId("__JBgITw9EeW3QqUkIQtIUA")]
    [DisplayName("Denied Status 17 Choice")]
    public abstract partial record DeniedStatus17Choice_
    {
    }
}
