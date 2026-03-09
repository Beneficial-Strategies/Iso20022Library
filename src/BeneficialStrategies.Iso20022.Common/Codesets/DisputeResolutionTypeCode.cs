// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcpaMdp-Ed-ak6NoX_4Aeg_-46223766")]
[Description(@"Specifies the nature of the disputed collateral amount.")]
[Derivations(typeof(DisputeResolutionType2Code),typeof(DisputeResolutionType1Code))]
public enum DisputeResolutionTypeCode
{
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_YcpaMtp-Ed-ak6NoX_4Aeg_1891365341")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the collateral.")]
    ReconcileCollateral,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the exposure.
    /// Encoded/decoded by serializers as &quot;REEX&quot;.
    /// </summary>
    [EnumMember(Value = "REEX")]
    [IsoId("_YcpaM9p-Ed-ak6NoX_4Aeg_-1059799862")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the exposure.")]
    ReconcileExposure,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the threshold.
    /// Encoded/decoded by serializers as &quot;RETH&quot;.
    /// </summary>
    [EnumMember(Value = "RETH")]
    [IsoId("_YcpaNNp-Ed-ak6NoX_4Aeg_1805713356")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the threshold.")]
    ReconcileThreshold,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.
    /// Encoded/decoded by serializers as &quot;RMTA&quot;.
    /// </summary>
    [EnumMember(Value = "RMTA")]
    [IsoId("_YcpaNdp-Ed-ak6NoX_4Aeg_-861205465")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the minimum transfer amount.")]
    ReconcileMinimumTransferAmount,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.
    /// Encoded/decoded by serializers as &quot;RERO&quot;.
    /// </summary>
    [EnumMember(Value = "RERO")]
    [IsoId("_YcpaNtp-Ed-ak6NoX_4Aeg_-266492912")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the rounding.")]
    ReconcileRounding,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.
    /// Encoded/decoded by serializers as &quot;REVF&quot;.
    /// </summary>
    [EnumMember(Value = "REVF")]
    [IsoId("_YcpaN9p-Ed-ak6NoX_4Aeg_-1878503321")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the valuation frequency.")]
    ReconcileValuationFrequency,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the independent amount.
    /// Encoded/decoded by serializers as &quot;RNIA&quot;.
    /// </summary>
    [EnumMember(Value = "RNIA")]
    [IsoId("_YcpaONp-Ed-ak6NoX_4Aeg_1220861070")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the independent amount.")]
    ReconcileNettedIndependentAmount,
    
    /// <summary>
    /// Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_YcpaOdp-Ed-ak6NoX_4Aeg_-1592735375")]
    [Description(@"Indicates that the disputed collateral amount should be confirmed through reconciliation of the initial margin.")]
    ReconcileSegregatedIndependentAmount,
    
}
