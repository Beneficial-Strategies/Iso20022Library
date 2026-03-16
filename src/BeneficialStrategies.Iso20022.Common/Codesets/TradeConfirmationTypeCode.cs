// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aR8RMQ26EeWmAKKPnqYEVQ")]
[Description(
    @"Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed."
)]
[Derivations(typeof(TradeConfirmationType2Code), typeof(TradeConfirmationType1Code))]
public enum TradeConfirmationTypeCode
{
    /// <summary>
    /// Non-electronically confirmed.
    /// Encoded/decoded by serializers as &quot;YCNF&quot;.
    /// </summary>
    [EnumMember(Value = "YCNF")]
    [IsoId("_iuIaYA26EeWmAKKPnqYEVQ")]
    [Description(@"Non-electronically confirmed.")]
    NonElectronicallyConfirmed,

    /// <summary>
    /// Electronically confirmed.
    /// Encoded/decoded by serializers as &quot;ECNF&quot;.
    /// </summary>
    [EnumMember(Value = "ECNF")]
    [IsoId("_lzHOUA26EeWmAKKPnqYEVQ")]
    [Description(@"Electronically confirmed.")]
    ElectronicallyConfirmed,

    /// <summary>
    /// Non-confirmed.
    /// Encoded/decoded by serializers as &quot;NCNF&quot;.
    /// </summary>
    [EnumMember(Value = "NCNF")]
    [IsoId("_l_myMA26EeWmAKKPnqYEVQ")]
    [Description(@"Non-confirmed.")]
    NonConfirmed,
}
