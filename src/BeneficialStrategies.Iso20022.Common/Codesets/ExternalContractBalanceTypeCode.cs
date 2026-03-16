// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a contract balance type code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kvoGMJGAEeeBGrZP1w0opg")]
[Description(
    @"Specifies a contract balance type code, as published in the external ISO 20022 external code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalContractBalanceType1Code))]
public enum ExternalContractBalanceTypeCode
{
    /// <summary>
    /// Revolver loan current utilisation (applicable on loan contracts types)
    /// Encoded/decoded by serializers as &quot;EXPC&quot;.
    /// </summary>
    [EnumMember(Value = "EXPC")]
    [IsoId("_uUDnc_RYEeuLhpyIdtJzwg")]
    [Description(@"Revolver loan current utilisation (applicable on loan contracts types)")]
    CurrentUtilisation,

    /// <summary>
    /// Total loan utilisation for loans with total loan limit  (applicable on loan contracts types)
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_uUDndvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Total loan utilisation for loans with total loan limit  (applicable on loan contracts types)"
    )]
    TotalUtilisation,
}
