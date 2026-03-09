// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the workflow status of the details of a specific level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pRyojL3EeKU9IrkkToqcw_-898186420")]
[Description(@"Specifies the workflow status of the details of a specific level.")]
[DerivedFrom(typeof(WorkflowStatusCode))]
public enum WorkflowStatus1Code
{
    /// <summary>
    /// Level details are complete. All required data is populated and verified.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_1pRyozL3EeKU9IrkkToqcw_-758053791")]
    [Description(@"Level details are complete. All required data is populated and verified.")]
    Complete = WorkflowStatusCode.Complete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Level details are incomplete due to conflicting details from 2 or more sources.
    /// Encoded/decoded by serializers as &quot;CNFL&quot;.
    /// </summary>
    [EnumMember(Value = "CNFL")]
    [IsoId("_1pRypDL3EeKU9IrkkToqcw_-1512803665")]
    [Description(@"Level details are incomplete due to conflicting details from 2 or more sources.")]
    Conflict = WorkflowStatusCode.Conflict, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Level details are complete pending a condition.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_1pRypTL3EeKU9IrkkToqcw_-1626642731")]
    [Description(@"Level details are complete pending a condition.")]
    ConditionallyComplete = WorkflowStatusCode.ConditionallyComplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Level details are incomplete.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_1pa8kDL3EeKU9IrkkToqcw_-752038512")]
    [Description(@"Level details are incomplete.")]
    Incomplete = WorkflowStatusCode.Incomplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Level has been deleted, cancelled/deactivated/invalidated by the source or due to error processing error.
    /// Encoded/decoded by serializers as &quot;DLTD&quot;.
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_1pa8kTL3EeKU9IrkkToqcw_-1069815173")]
    [Description(@"Level has been deleted, cancelled/deactivated/invalidated by the source or due to error processing error.")]
    Deleted = WorkflowStatusCode.Deleted, // same ordinal as derivation source for type conversions
    
}
