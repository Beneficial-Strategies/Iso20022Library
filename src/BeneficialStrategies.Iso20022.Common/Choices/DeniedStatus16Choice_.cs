// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus16Choice.Reason))]
    [JsonDerivedType(
        typeof(DeniedStatus16Choice.NoSpecifiedReason),
        nameof(DeniedStatus16Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(DeniedStatus16Choice.Reason), nameof(DeniedStatus16Choice.Reason))]
    [IsoId("_tSPYkTs8EeWRTLSN0i0tng")]
    [DisplayName("Denied Status 16 Choice")]
    public abstract record DeniedStatus16Choice_ { }
}
