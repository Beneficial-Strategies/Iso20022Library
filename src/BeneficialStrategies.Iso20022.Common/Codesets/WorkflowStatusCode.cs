// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the workflow status of the details of a specific level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1nx90jL3EeKU9IrkkToqcw_-1815438950")]
[Description(@"Specifies the workflow status of the details of a specific level.")]
[Derivations(typeof(WorkflowStatus1Code))]
public enum WorkflowStatusCode
{
    /// <summary>
    /// Level details are complete. All required data is populated and verified.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_1nx90zL3EeKU9IrkkToqcw_-1062462899")]
    [Description(@"Level details are complete. All required data is populated and verified.")]
    Complete,

    /// <summary>
    /// Level details are incomplete due to conflicting details from 2 or more sources.
    /// Encoded/decoded by serializers as &quot;CNFL&quot;.
    /// </summary>
    [EnumMember(Value = "CNFL")]
    [IsoId("_1nx91DL3EeKU9IrkkToqcw_1685878057")]
    [Description(
        @"Level details are incomplete due to conflicting details from 2 or more sources."
    )]
    Conflict,

    /// <summary>
    /// Level details are complete pending a condition.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_1nx91TL3EeKU9IrkkToqcw_-1793170858")]
    [Description(@"Level details are complete pending a condition.")]
    ConditionallyComplete,

    /// <summary>
    /// Level details are incomplete.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_1n7u0DL3EeKU9IrkkToqcw_868726079")]
    [Description(@"Level details are incomplete.")]
    Incomplete,

    /// <summary>
    /// Level has been deleted, cancelled/deactivated/invalidated by the source or due to error processing error.
    /// Encoded/decoded by serializers as &quot;DLTD&quot;.
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_1n7u0TL3EeKU9IrkkToqcw_-1903689822")]
    [Description(
        @"Level has been deleted, cancelled/deactivated/invalidated by the source or due to error processing error."
    )]
    Deleted,
}
