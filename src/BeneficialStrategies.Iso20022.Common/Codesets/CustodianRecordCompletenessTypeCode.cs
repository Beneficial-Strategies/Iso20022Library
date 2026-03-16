// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of details of the composite record on the system. Applicable to custodian service only.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11fptTL3EeKU9IrkkToqcw_1241268024")]
[Description(
    @"Specifies the state of details of the composite record on the system. Applicable to custodian service only."
)]
[Derivations(typeof(CustodianRecordCompletenessType1Code))]
public enum CustodianRecordCompletenessTypeCode
{
    /// <summary>
    /// Custodian record is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_11pasDL3EeKU9IrkkToqcw_-85851678")]
    [Description(@"Custodian record is complete.")]
    Complete,

    /// <summary>
    /// Custodian record is incomplete.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_11pasTL3EeKU9IrkkToqcw_-167921638")]
    [Description(@"Custodian record is incomplete.")]
    Incomplete,

    /// <summary>
    /// Custodian record is conditionally complete.
    /// Encoded/decoded by serializers as &quot;CCOM&quot;.
    /// </summary>
    [EnumMember(Value = "CCOM")]
    [IsoId("_11pasjL3EeKU9IrkkToqcw_-1808310521")]
    [Description(@"Custodian record is conditionally complete.")]
    ConditionallyComplete,
}
