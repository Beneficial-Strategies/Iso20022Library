// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the assignment of a proxy is not allowed for the meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWd-Jdp-Ed-ak6NoX_4Aeg_-1352917034")]
[Description(@"Indicates that the assignment of a proxy is not allowed for the meeting.")]
[Derivations(typeof(ProxyNotAllowed1Code))]
public enum ProxyNotAllowedCode
{
    /// <summary>
    /// Proxy not allowed.
    /// Encoded/decoded by serializers as &quot;NPRO&quot;.
    /// </summary>
    [EnumMember(Value = "NPRO")]
    [IsoId("_ZWd-Jtp-Ed-ak6NoX_4Aeg_-1195919766")]
    [Description(@"Proxy not allowed.")]
    NotAllowed,
}
