// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Transfer, PEP or ISA.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aGcpkdp-Ed-ak6NoX_4Aeg_1893653072")]
[Description(@"Specifies the type of Transfer, PEP or ISA.")]
[Derivations()]
public enum PEPISACode
{
    /// <summary>
    /// Personal equity plan.
    /// Encoded/decoded by serializers as &quot;PEPT&quot;.
    /// </summary>
    [EnumMember(Value = "PEPT")]
    [IsoId("_aGcpktp-Ed-ak6NoX_4Aeg_-1535050554")]
    [Description(@"Personal equity plan.")]
    PEP,

    /// <summary>
    /// Individual savings account.
    /// Encoded/decoded by serializers as &quot;ISAT&quot;.
    /// </summary>
    [EnumMember(Value = "ISAT")]
    [IsoId("_aGcpk9p-Ed-ak6NoX_4Aeg_-1061285641")]
    [Description(@"Individual savings account.")]
    ISA,
}
