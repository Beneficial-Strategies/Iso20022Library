// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies status of the instruction lock (for elections).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oFf1TL3EeKU9IrkkToqcw_-1695680614")]
[Description(@"Specifies status of the instruction lock (for elections).")]
[Derivations(typeof(InstructionLockout1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstructionLockoutCode>))]
#endif
public enum InstructionLockoutCode
{
    /// <summary>
    /// System suspended elections processing based on business rules.
    /// Encoded/decoded by serializers as &quot;SYLK&quot;.
    /// </summary>
    [EnumMember(Value = "SYLK")]
    [IsoId("_1oOpwDL3EeKU9IrkkToqcw_-978797614")]
    [Description(@"System suspended elections processing based on business rules.")]
    SystemicLocked,

    /// <summary>
    /// DTC (the Depository Trust Company) personnel suspended elections processing.
    /// Encoded/decoded by serializers as &quot;MALK&quot;.
    /// </summary>
    [EnumMember(Value = "MALK")]
    [IsoId("_1oOpwTL3EeKU9IrkkToqcw_1556868203")]
    [Description(@"DTC (the Depository Trust Company) personnel suspended elections processing.")]
    ManualLocked,

    /// <summary>
    /// Eligible for elections processing.
    /// Encoded/decoded by serializers as &quot;NOLO&quot;.
    /// </summary>
    [EnumMember(Value = "NOLO")]
    [IsoId("_1oOpwjL3EeKU9IrkkToqcw_-748248972")]
    [Description(@"Eligible for elections processing.")]
    NotLocked,
}
