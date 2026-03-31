// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the instruction lock (for elections).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1tJmAzL3EeKU9IrkkToqcw_-1498537719")]
[Description(@"Specifies the status of the instruction lock (for elections).")]
[DerivedFrom(typeof(InstructionLockoutCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstructionLockout1Code>))]
#endif
public enum InstructionLockout1Code
{
    /// <summary>
    /// System suspended elections processing based on business rules.
    /// Encoded/decoded by serializers as &quot;SYLK&quot;.
    /// </summary>
    [EnumMember(Value = "SYLK")]
    [IsoId("_1tJmBDL3EeKU9IrkkToqcw_-1287259278")]
    [Description(@"System suspended elections processing based on business rules.")]
    SystemicLocked = InstructionLockoutCode.SystemicLocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DTC (the Depository Trust Company) personnel suspended elections processing.
    /// Encoded/decoded by serializers as &quot;MALK&quot;.
    /// </summary>
    [EnumMember(Value = "MALK")]
    [IsoId("_1tTXADL3EeKU9IrkkToqcw_964591391")]
    [Description(@"DTC (the Depository Trust Company) personnel suspended elections processing.")]
    ManualLocked = InstructionLockoutCode.ManualLocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Eligible for elections processing.
    /// Encoded/decoded by serializers as &quot;NOLO&quot;.
    /// </summary>
    [EnumMember(Value = "NOLO")]
    [IsoId("_1tTXATL3EeKU9IrkkToqcw_1289708898")]
    [Description(@"Eligible for elections processing.")]
    NotLocked = InstructionLockoutCode.NotLocked, // same ordinal as derivation source for type conversions
}
