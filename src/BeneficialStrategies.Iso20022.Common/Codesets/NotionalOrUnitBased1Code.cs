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
[IsoId("_xlFEgJ9WEeqxTNfi5y7ywQ")]
[Description(@"Specifies the unit basis of a financial instrument.")]
[DerivedFrom(typeof(NotionalOrUnitBasedCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NotionalOrUnitBased1Code>))]
#endif
public enum NotionalOrUnitBased1Code
{
    /// <summary>
    /// Basis of a financial instrument is unit.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_1AhQoZ9WEeqxTNfi5y7ywQ")]
    [Description(@"Basis of a financial instrument is unit.")]
    Unit = NotionalOrUnitBasedCode.Unit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Basis of a financial instrument is notional.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_1G6zkZ9WEeqxTNfi5y7ywQ")]
    [Description(@"Basis of a financial instrument is notional.")]
    Notional = NotionalOrUnitBasedCode.Notional, // same ordinal as derivation source for type conversions
}
