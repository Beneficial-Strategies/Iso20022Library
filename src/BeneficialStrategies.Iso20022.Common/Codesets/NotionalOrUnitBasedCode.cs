// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the unit basis of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S2Sb8J9WEeqxTNfi5y7ywQ")]
[Description(@"Specifies the unit basis of a financial instrument.")]
[Derivations(typeof(NotionalOrUnitBased1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NotionalOrUnitBasedCode>))]
#endif
public enum NotionalOrUnitBasedCode
{
    /// <summary>
    /// Basis of a financial instrument is unit.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_gfcZQJ9WEeqxTNfi5y7ywQ")]
    [Description(@"Basis of a financial instrument is unit.")]
    Unit,

    /// <summary>
    /// Basis of a financial instrument is notional.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_nVu7oJ9WEeqxTNfi5y7ywQ")]
    [Description(@"Basis of a financial instrument is notional.")]
    Notional,
}
