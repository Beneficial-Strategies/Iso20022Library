// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Explanation or reason for the action being taken on the transaction reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-T9QACjAEeuKKc2MztSwPw")]
[Description(@"Explanation or reason for the action being taken on the transaction reporting.")]
public enum DerivativeEventTypeCode
{
    /// <summary>
    /// Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_TBE_UCjBEeuKKc2MztSwPw")]
    [Description(@"Conclusion of a derivative or renegotiation of its terms that does not result in change of a counterparty.")]
    Trade,
    
    /// <summary>
    /// The replacement of a party to a derivative contract with another party giving rise to a new derivative contract.
    /// Encoded/decoded by serializers as &quot;NOVA&quot;.
    /// </summary>
    [EnumMember(Value = "NOVA")]
    [IsoId("_aBVWACjBEeuKKc2MztSwPw")]
    [Description(@"The replacement of a party to a derivative contract with another party giving rise to a new derivative contract.")]
    Novation,
    
    /// <summary>
    /// Compression or post-trade risk reduction exercise.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_d4cKcCjBEeuKKc2MztSwPw")]
    [Description(@"Compression or post-trade risk reduction exercise.|")]
    Compression,
    
    /// <summary>
    /// Termination of an existing derivative transaction prior to scheduled termination or maturity date.
    /// Encoded/decoded by serializers as &quot;ETRM&quot;.
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_hCoOgCjBEeuKKc2MztSwPw")]
    [Description(@"Termination of an existing derivative transaction prior to scheduled termination or maturity date.")]
    EarlyTermination,
    
    /// <summary>
    /// Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer
    /// Encoded/decoded by serializers as &quot;CLRG&quot;.
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_lCqVcCjBEeuKKc2MztSwPw")]
    [Description(@"Process in which a CCP interposes itself between the counterparties to the contract becoming the buyer to the counterparty that was a seller and the seller to the counterparty that was a buyer")]
    Clearing,
    
    /// <summary>
    /// The exercise of an option or a swaption by one counterparty of the transaction, fully or partially. 
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_qTyQ0CjBEeuKKc2MztSwPw")]
    [Description(@"The exercise of an option or a swaption by one counterparty of the transaction, fully or partially. |")]
    Exercise,
    
    /// <summary>
    /// Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives with reduced notional amounts.
    /// Encoded/decoded by serializers as &quot;ALOC&quot;.
    /// </summary>
    [EnumMember(Value = "ALOC")]
    [IsoId("_s2ZXgCjBEeuKKc2MztSwPw")]
    [Description(@"Allocation event, where an existing derivative is allocated to different counterparties and reported as new derivatives with reduced notional amounts.")]
    Allocation,
    
    /// <summary>
    /// Applies only to credit derivatives. A credit event that results in a modification of a derivative, at a trade or position level
    /// Encoded/decoded by serializers as &quot;CREV&quot;.
    /// </summary>
    [EnumMember(Value = "CREV")]
    [IsoId("_w3enUCjBEeuKKc2MztSwPw")]
    [Description(@"Applies only to credit derivatives. A credit event that results in a modification of a derivative, at a trade or position level")]
    CreditEvent,
    
    /// <summary>
    /// Result of a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_zwQLQCjBEeuKKc2MztSwPw")]
    [Description(@"Result of a corporate action.")]
    CorporateAction,
    
    /// <summary>
    /// Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_4aP1MCjBEeuKKc2MztSwPw")]
    [Description(@"Inclusion of an ETD or CFD into a position, where an existing derivative is terminated and either a new position is created or the notional of an existing position is modified.")]
    InclusionInPosition,
    
    /// <summary>
    /// Outstanding derivative is updated to comply with the revised requirements on reporting.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_82jBYCjBEeuKKc2MztSwPw")]
    [Description(@"Outstanding derivative is updated to comply with the revised requirements on reporting.")]
    Update,
    
    /// <summary>
    /// Simultaneous clearing and allocation event in a derivatives clearing organisation.
    /// Encoded/decoded by serializers as &quot;CLAL&quot;.
    /// </summary>
    [EnumMember(Value = "CLAL")]
    [IsoId("_0_py4CsMEeuBCuYCb8AfiA")]
    [Description(@"Simultaneous clearing and allocation event in a derivatives clearing organisation.")]
    ClearingAndAllocation,
    
    /// <summary>
    /// The process by which a derivative transaction is transferred to another trade repository using the same UTI.
    /// Encoded/decoded by serializers as &quot;PTNG&quot;.
    /// </summary>
    [EnumMember(Value = "PTNG")]
    [IsoId("_YrngESsNEeuBCuYCb8AfiA")]
    [Description(@"The process by which a derivative transaction is transferred to another trade repository using the same UTI.")]
    Porting,
    
    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_mCBggCsNEeuBCuYCb8AfiA")]
    [Description(@"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.")]
    Revive,
    
}
