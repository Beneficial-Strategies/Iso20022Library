// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether an automatic routing system is involved.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bj4Q5Np-Ed-ak6NoX_4Aeg_1039779413")]
[Description(@"Indicates whether an automatic routing system is involved.")]
[DerivedFrom(typeof(AutoRoutingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AutoRouting1Code>))]
#endif
public enum AutoRouting1Code
{
    /// <summary>
    /// Indicates the Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.
    /// Encoded/decoded by serializers as &quot;DDOT&quot;.
    /// </summary>
    [EnumMember(Value = "DDOT")]
    [IsoId("_bj4Q5dp-Ed-ak6NoX_4Aeg_1094266206")]
    [Description(
        @"Indicates the Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used."
    )]
    DOTSystem = AutoRoutingCode.DOTSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the evolution of the DOT system, a Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.
    /// Encoded/decoded by serializers as &quot;SDOT&quot;.
    /// </summary>
    [EnumMember(Value = "SDOT")]
    [IsoId("_bj4Q5tp-Ed-ak6NoX_4Aeg_1094266241")]
    [Description(
        @"Indicates the evolution of the DOT system, a Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used."
    )]
    SuperDOTSystem = AutoRoutingCode.SuperDOTSystem, // same ordinal as derivation source for type conversions
}
