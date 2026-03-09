// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcgQQtp-Ed-ak6NoX_4Aeg_1011613504")]
[Description(@"Specifies the nature of the disputed collateral amount.")]
[DerivedFrom(typeof(DisputeResolutionTypeCode))]
public enum DisputeResolutionType2Code
{
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YcgQQ9p-Ed-ak6NoX_4Aeg_1772378657")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.")]
    ReconcileCollateral = DisputeResolutionTypeCode.ReconcileCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the exposure.
    /// Encoded/decoded by serializers as &quot;REEX&quot;.
    /// </summary>
    [EnumMember(Value = "REEX")]
    [IsoId("_YcgQRNp-Ed-ak6NoX_4Aeg_1658539591")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the exposure.")]
    ReconcileExposure = DisputeResolutionTypeCode.ReconcileExposure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the threshold.
    /// Encoded/decoded by serializers as &quot;RETH&quot;.
    /// </summary>
    [EnumMember(Value = "RETH")]
    [IsoId("_YcgQRdp-Ed-ak6NoX_4Aeg_1939398552")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the threshold.")]
    ReconcileThreshold = DisputeResolutionTypeCode.ReconcileThreshold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.
    /// Encoded/decoded by serializers as &quot;RMTA&quot;.
    /// </summary>
    [EnumMember(Value = "RMTA")]
    [IsoId("_YcgQRtp-Ed-ak6NoX_4Aeg_1825559486")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.")]
    ReconcileMinimumTransferAmount = DisputeResolutionTypeCode.ReconcileMinimumTransferAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.
    /// Encoded/decoded by serializers as &quot;RERO&quot;.
    /// </summary>
    [EnumMember(Value = "RERO")]
    [IsoId("_YcgQR9p-Ed-ak6NoX_4Aeg_-460290170")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.")]
    ReconcileRounding = DisputeResolutionTypeCode.ReconcileRounding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.
    /// Encoded/decoded by serializers as &quot;REVF&quot;.
    /// </summary>
    [EnumMember(Value = "REVF")]
    [IsoId("_YcgQSNp-Ed-ak6NoX_4Aeg_-1215040044")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.")]
    ReconcileValuationFrequency = DisputeResolutionTypeCode.ReconcileValuationFrequency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the independent amount.
    /// Encoded/decoded by serializers as &quot;RNIA&quot;.
    /// </summary>
    [EnumMember(Value = "RNIA")]
    [IsoId("_YcpaMNp-Ed-ak6NoX_4Aeg_-1850071890")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the independent amount.")]
    ReconcileNettedIndependentAmount = DisputeResolutionTypeCode.ReconcileNettedIndependentAmount, // same ordinal as derivation source for type conversions
    
}
