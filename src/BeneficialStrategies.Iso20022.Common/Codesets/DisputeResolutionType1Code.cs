// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcWfRdp-Ed-ak6NoX_4Aeg_-299139141")]
[Description(@"Specifies the nature of the disputed collateral amount.")]
[DerivedFrom(typeof(DisputeResolutionTypeCode))]
public enum DisputeResolutionType1Code
{
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YcWfRtp-Ed-ak6NoX_4Aeg_-1118092822")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.")]
    ReconcileCollateral = DisputeResolutionTypeCode.ReconcileCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.
    /// Encoded/decoded by serializers as &quot;RMTA&quot;.
    /// </summary>
    [EnumMember(Value = "RMTA")]
    [IsoId("_YcWfR9p-Ed-ak6NoX_4Aeg_2050150903")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.")]
    ReconcileMinimumTransferAmount = DisputeResolutionTypeCode.ReconcileMinimumTransferAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.
    /// Encoded/decoded by serializers as &quot;RERO&quot;.
    /// </summary>
    [EnumMember(Value = "RERO")]
    [IsoId("_YcWfSNp-Ed-ak6NoX_4Aeg_-716740705")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.")]
    ReconcileRounding = DisputeResolutionTypeCode.ReconcileRounding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.
    /// Encoded/decoded by serializers as &quot;REVF&quot;.
    /// </summary>
    [EnumMember(Value = "REVF")]
    [IsoId("_YcgQQNp-Ed-ak6NoX_4Aeg_-754726748")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.")]
    ReconcileValuationFrequency = DisputeResolutionTypeCode.ReconcileValuationFrequency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_YcgQQdp-Ed-ak6NoX_4Aeg_-1509476622")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.")]
    ReconcileSegregatedIndependentAmount = DisputeResolutionTypeCode.ReconcileSegregatedIndependentAmount, // same ordinal as derivation source for type conversions
    
}
