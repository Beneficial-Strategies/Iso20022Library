// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for an enabled status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-ul2sGBgEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for an enabled status.")]
[Derivations(typeof(EnabledStatusReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EnabledStatusReasonCode>))]
#endif
public enum EnabledStatusReasonCode
{
    /// <summary>
    /// Modification to the account data is in process.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_Cny84GBhEeaR1OOiVxm3Gg")]
    [Description(@"Modification to the account data is in process.")]
    Modified,
}
