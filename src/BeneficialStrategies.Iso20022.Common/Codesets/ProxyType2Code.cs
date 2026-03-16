// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of proxy person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWd-J9p-Ed-ak6NoX_4Aeg_-929799410")]
[Description(@"Specifies the type of proxy person.")]
[DerivedFrom(typeof(ProxyTypeCode))]
public enum ProxyType2Code
{
    /// <summary>
    /// Chairman of the meeting is the proxy.
    /// Encoded/decoded by serializers as &quot;CHRM&quot;.
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_ZWd-KNp-Ed-ak6NoX_4Aeg_-885468111")]
    [Description(@"Chairman of the meeting is the proxy.")]
    Chairman = ProxyTypeCode.Chairman, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any type of proxy is allowed.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ZWnIENp-Ed-ak6NoX_4Aeg_-885468041")]
    [Description(@"Any type of proxy is allowed.")]
    Discretionary = ProxyTypeCode.Discretionary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proxy can only be a security holder.
    /// Encoded/decoded by serializers as &quot;HLDR&quot;.
    /// </summary>
    [EnumMember(Value = "HLDR")]
    [IsoId("_ZWnIEdp-Ed-ak6NoX_4Aeg_-1812267007")]
    [Description(@"Proxy can only be a security holder.")]
    SecurityHolder = ProxyTypeCode.SecurityHolder, // same ordinal as derivation source for type conversions
}
