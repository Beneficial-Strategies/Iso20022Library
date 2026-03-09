// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPw5Mdp-Ed-ak6NoX_4Aeg_1122595996")]
[Description(@"Specifies the type of standing instruction.")]
[Derivations(typeof(StandingInstructionGrossNet1Code))]
public enum StandingInstructionGrossNetCode
{
    /// <summary>
    /// Gross payment.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_ZPw5Mtp-Ed-ak6NoX_4Aeg_-42230364")]
    [Description(@"Gross payment.")]
    Gross,
    
    /// <summary>
    /// Net payment.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZPw5M9p-Ed-ak6NoX_4Aeg_-42230333")]
    [Description(@"Net payment.")]
    Net,
    
}
