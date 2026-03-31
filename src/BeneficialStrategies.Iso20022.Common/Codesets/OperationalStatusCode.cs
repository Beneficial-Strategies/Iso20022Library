// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifes the operational status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w6pwoCDYEeWCLu74WLgP4w")]
[Description(@"Specifes the operational status.")]
[Derivations(typeof(OperationalStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OperationalStatusCode>))]
#endif
public enum OperationalStatusCode
{
    /// <summary>
    /// Enabled.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_8DcqACDYEeWCLu74WLgP4w")]
    [Description(@"Enabled.")]
    Enabled,

    /// <summary>
    /// Special circumstances.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("__qqBQCDYEeWCLu74WLgP4w")]
    [Description(@"Special circumstances.")]
    SpecialCircumstances,
}
