// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates how an option trade is settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOREYdp-Ed-ak6NoX_4Aeg_-218476844")]
[Description(@"Indicates how an option trade is settled.")]
[Derivations(typeof(SettlementType1Code))]
public enum SettlementTypeCode
{
    /// <summary>
    /// Option trade is settled as principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_ZOREYtp-Ed-ak6NoX_4Aeg_-149211342")]
    [Description(@"Option trade is settled as principal.")]
    Principal,

    /// <summary>
    /// Option trade is netted off against another trade.
    /// Encoded/decoded by serializers as &quot;NETO&quot;.
    /// </summary>
    [EnumMember(Value = "NETO")]
    [IsoId("_ZOREY9p-Ed-ak6NoX_4Aeg_122301287")]
    [Description(@"Option trade is netted off against another trade.")]
    NettedOff,
}
