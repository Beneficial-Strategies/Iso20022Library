// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of allocation of collateral to cover the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_boymEtp-Ed-ak6NoX_4Aeg_-1844046552")]
[Description(@"Specifies the status of allocation of collateral to cover the instruction.")]
[Derivations(typeof(AllocationStatus1Code))]
public enum AllocationStatusCode
{
    /// <summary>
    /// Instruction has been fully covered by collateral.
    /// Encoded/decoded by serializers as &quot;AOLF&quot;.
    /// </summary>
    [EnumMember(Value = "AOLF")]
    [IsoId("_boymE9p-Ed-ak6NoX_4Aeg_-1510657003")]
    [Description(@"Instruction has been fully covered by collateral.")]
    FullyAllocated,

    /// <summary>
    /// Instruction has been partially covered by collateral.
    /// Encoded/decoded by serializers as &quot;AOLP&quot;.
    /// </summary>
    [EnumMember(Value = "AOLP")]
    [IsoId("_boymFNp-Ed-ak6NoX_4Aeg_-1510654068")]
    [Description(@"Instruction has been partially covered by collateral.")]
    PartiallyAllocated,
}
