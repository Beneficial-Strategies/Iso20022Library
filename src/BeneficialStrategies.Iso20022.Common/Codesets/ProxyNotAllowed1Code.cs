// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the assignment of a proxy is not allowed for the meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hlcnIMjCEem7mOT-LZ2mYQ")]
[Description(@"Indicates that the assignment of a proxy is not allowed for the meeting.")]
[DerivedFrom(typeof(ProxyNotAllowedCode))]
public enum ProxyNotAllowed1Code
{
    /// <summary>
    /// Proxy not allowed.
    /// Encoded/decoded by serializers as &quot;NPRO&quot;.
    /// </summary>
    [EnumMember(Value = "NPRO")]
    [IsoId("_jssAccjCEem7mOT-LZ2mYQ")]
    [Description(@"Proxy not allowed.")]
    NotAllowed = ProxyNotAllowedCode.NotAllowed, // same ordinal as derivation source for type conversions
    
}
