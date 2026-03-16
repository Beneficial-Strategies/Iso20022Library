// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the structure of the fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atyWZNp-Ed-ak6NoX_4Aeg_-1618399361")]
[Description(@"Specifies the structure of the fund.")]
public enum FundStructureCode
{
    /// <summary>
    /// Investment fund that contains more than one investment fund class.
    /// Encoded/decoded by serializers as &quot;MFUN&quot;.
    /// </summary>
    [EnumMember(Value = "MFUN")]
    [IsoId("_atyWZdp-Ed-ak6NoX_4Aeg_-1363507035")]
    [Description(@"Investment fund that contains more than one investment fund class.")]
    MultiClassFund,

    /// <summary>
    /// Investment fund that contains only one investment fund class.
    /// Encoded/decoded by serializers as &quot;SFUN&quot;.
    /// </summary>
    [EnumMember(Value = "SFUN")]
    [IsoId("_atyWZtp-Ed-ak6NoX_4Aeg_-904519550")]
    [Description(@"Investment fund that contains only one investment fund class.")]
    SingleClassFund,
}
