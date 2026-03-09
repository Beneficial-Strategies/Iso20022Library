// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of details of the composite record on the system. Applicable to custodian service only.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11paszL3EeKU9IrkkToqcw_1964560171")]
[Description(@"Specifies the state of details of the composite record on the system. Applicable to custodian service only.")]
[DerivedFrom(typeof(CustodianRecordCompletenessTypeCode))]
public enum CustodianRecordCompletenessType1Code
{
    /// <summary>
    /// Custodian record is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_11patDL3EeKU9IrkkToqcw_2131580066")]
    [Description(@"Custodian record is complete.")]
    Complete = CustodianRecordCompletenessTypeCode.Complete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custodian record is incomplete.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_11patTL3EeKU9IrkkToqcw_439399869")]
    [Description(@"Custodian record is incomplete.")]
    Incomplete = CustodianRecordCompletenessTypeCode.Incomplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custodian record is conditionally complete.
    /// Encoded/decoded by serializers as &quot;CCOM&quot;.
    /// </summary>
    [EnumMember(Value = "CCOM")]
    [IsoId("_11patjL3EeKU9IrkkToqcw_893487138")]
    [Description(@"Custodian record is conditionally complete.")]
    ConditionallyComplete = CustodianRecordCompletenessTypeCode.ConditionallyComplete, // same ordinal as derivation source for type conversions
    
}
