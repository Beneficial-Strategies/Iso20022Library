// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RDOJRh-yEeuxStysDTgLiw")]
[Description(@"Specifies the status for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleStatus2Code
{
    /// <summary>
    /// Accepted technical validation.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_nXe9cSAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted technical validation.")]
    AcceptedTechnicalValidation = ValidationRuleCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accepted customer profile.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_nXe9cyAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted customer profile.")]
    AcceptedCustomerProfile = ValidationRuleCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accepted settlement in process.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_nXe9dSAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted settlement in process.")]
    AcceptedSettlementInProcess = ValidationRuleCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accepted settlement completed.
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_nXe9dyAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted settlement completed.")]
    AcceptedSettlementCompleted = ValidationRuleCode.AcceptedSettlementCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accepted cancellation request.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_nXe9eSAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted cancellation request.")]
    AcceptedCancellationRequest = ValidationRuleCode.AcceptedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accepted with change.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_nXe9eyAeEeuSiN6KdHu9iw")]
    [Description(@"Accepted with change.")]
    AcceptedWithChange = ValidationRuleCode.AcceptedWithChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_nXe9fSAeEeuSiN6KdHu9iw")]
    [Description(@"Pending.")]
    Pending = ValidationRuleCode.Pending, // same ordinal as derivation source for type conversions
    
}
