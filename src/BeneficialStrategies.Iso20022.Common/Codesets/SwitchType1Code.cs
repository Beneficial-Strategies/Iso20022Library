// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the switch either full or part for a given account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wQUvEA2YEeSNWNtJlXOAhg")]
[Description(@"Specifies the status of the switch either full or part for a given account.")]
[DerivedFrom(typeof(SwitchTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SwitchType1Code>))]
#endif
public enum SwitchType1Code
{
    /// <summary>
    /// Indicates a full switch for an account.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_xBa00Q2YEeSNWNtJlXOAhg")]
    [Description(@"Indicates a full switch for an account.")]
    FullSwitch = SwitchTypeCode.FullSwitch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates a partial switch for an account.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_xGBoAQ2YEeSNWNtJlXOAhg")]
    [Description(@"Indicates a partial switch for an account.")]
    PartSwitch = SwitchTypeCode.PartSwitch, // same ordinal as derivation source for type conversions
}
