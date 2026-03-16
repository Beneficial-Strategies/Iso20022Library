// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a deemed rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wNAYIJSkEeeh5JjedkaA_g")]
[Description(@"Specifies the type of a deemed rate.")]
[Derivations(typeof(DeemedRateType1Code))]
public enum DeemedRateTypeCode
{
    /// <summary>
    /// Deemed rate of interest proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DEIT&quot;.
    /// </summary>
    [EnumMember(Value = "DEIT")]
    [IsoId("_LmfRwJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of interest proceeds attributed to the security holder.")]
    DeemedInterestProceeds,

    /// <summary>
    /// Deemed rate of dividend proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DEDI&quot;.
    /// </summary>
    [EnumMember(Value = "DEDI")]
    [IsoId("_Qgj_EJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of dividend proceeds attributed to the security holder.")]
    DeemedDividendProceeds,

    /// <summary>
    /// Deemed rate of fund proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DEFP&quot;.
    /// </summary>
    [EnumMember(Value = "DEFP")]
    [IsoId("_U-XAEJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of fund proceeds attributed to the security holder.")]
    DeemedFundProceeds,

    /// <summary>
    /// Deemed rate of royalties proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as &quot;DERY&quot;.
    /// </summary>
    [EnumMember(Value = "DERY")]
    [IsoId("_cXd7oJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of royalties proceeds attributed to the security holder.")]
    DeemedRoyaltiesProceeds,
}
