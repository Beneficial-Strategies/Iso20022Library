// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of allocation of collateral to cover the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bopcJ9p-Ed-ak6NoX_4Aeg_1464332533")]
[Description(@"Specifies the status of allocation of collateral to cover the instruction.")]
[DerivedFrom(typeof(AllocationStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AllocationStatus1Code>))]
#endif
public enum AllocationStatus1Code
{
    /// <summary>
    /// Instruction has been fully covered by collateral.
    /// Encoded/decoded by serializers as &quot;AOLF&quot;.
    /// </summary>
    [EnumMember(Value = "AOLF")]
    [IsoId("_boymENp-Ed-ak6NoX_4Aeg_1464332565")]
    [Description(@"Instruction has been fully covered by collateral.")]
    FullyAllocated = AllocationStatusCode.FullyAllocated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been partially covered by collateral.
    /// Encoded/decoded by serializers as &quot;AOLP&quot;.
    /// </summary>
    [EnumMember(Value = "AOLP")]
    [IsoId("_boymEdp-Ed-ak6NoX_4Aeg_1464332594")]
    [Description(@"Instruction has been partially covered by collateral.")]
    PartiallyAllocated = AllocationStatusCode.PartiallyAllocated, // same ordinal as derivation source for type conversions
}
