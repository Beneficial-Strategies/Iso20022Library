// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether there is cash in the account that is awaiting investment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qoyqE_peEeCLMa5EIHtDrg")]
[Description(@"Specifies whether there is cash in the account that is awaiting investment.")]
[Derivations(typeof(ResidualCash1Code))]
public enum ResidualCashCode
{
    /// <summary>
    /// Residual cash to be transferred.
    /// Encoded/decoded by serializers as &quot;RCTR&quot;.
    /// </summary>
    [EnumMember(Value = "RCTR")]
    [IsoId("_rpeD8fpeEeCLMa5EIHtDrg")]
    [Description(@"Residual cash to be transferred.")]
    ResidualCashTransfer,

    /// <summary>
    /// Residual Cash not to be transferred.
    /// Encoded/decoded by serializers as &quot;NRCT&quot;.
    /// </summary>
    [EnumMember(Value = "NRCT")]
    [IsoId("_2wSAV_peEeCLMa5EIHtDrg")]
    [Description(@"Residual Cash not to be transferred.")]
    NotResidualCashTransfer,
}
