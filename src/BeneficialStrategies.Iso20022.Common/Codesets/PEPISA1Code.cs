// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Transfer, PEP or ISA.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdTdcw93EeGeV5vP7Mvdig_1618918841")]
[Description(@"Specifies the type of Transfer, PEP or ISA.")]
[DerivedFrom(typeof(PEPISACode))]
public enum PEPISA1Code
{
    /// <summary>
    /// Personal equity plan.
    /// Encoded/decoded by serializers as &quot;PEPT&quot;.
    /// </summary>
    [EnumMember(Value = "PEPT")]
    [IsoId("_zdTddA93EeGeV5vP7Mvdig_-2054941291")]
    [Description(@"Personal equity plan.")]
    PEP = PEPISACode.PEP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Individual savings account.
    /// Encoded/decoded by serializers as &quot;ISAT&quot;.
    /// </summary>
    [EnumMember(Value = "ISAT")]
    [IsoId("_zdTddQ93EeGeV5vP7Mvdig_865100993")]
    [Description(@"Individual savings account.")]
    ISA = PEPISACode.ISA, // same ordinal as derivation source for type conversions
    
}
