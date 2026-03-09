// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of withholding tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gI-FsCeFEeOXAt_43VmZGw")]
[Description(@"Specifies the type of withholding tax rate.")]
[Derivations(typeof(WithholdingTaxRateType1Code))]
public enum WithholdingTaxRateTypeCode
{
    /// <summary>
    /// Withholding tax related to income subject to FATCA (Foreign Account Tax Compliance Act).
    /// Encoded/decoded by serializers as &quot;FTCA&quot;.
    /// </summary>
    [EnumMember(Value = "FTCA")]
    [IsoId("_xdqgoCeFEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to income subject to FATCA (Foreign Account Tax Compliance Act).")]
    FATCATax,
    
    /// <summary>
    /// Withholding tax related to income subject to NRA (Non Resident Alien).
    /// Encoded/decoded by serializers as &quot;NRAT&quot;.
    /// </summary>
    [EnumMember(Value = "NRAT")]
    [IsoId("_3gCSwCeFEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to income subject to NRA (Non Resident Alien).")]
    NRATax,
    
    /// <summary>
    /// Withholding tax related to payments subject to back up withholding.
    /// Encoded/decoded by serializers as &quot;BWIT&quot;.
    /// </summary>
    [EnumMember(Value = "BWIT")]
    [IsoId("_-AKX4CeFEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to payments subject to back up withholding.")]
    BackUpWithholding,
    
}
