// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of investment account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pXBs0F2cEeiFXdiLi_Nf4A")]
[Description(@"Specifies a type of investment account.")]
[Derivations(typeof(GeneralInvestmentAccountType1Code), typeof(GeneralInvestmentAccountType2Code))]
public enum GeneralInvestmentAccountTypeCode
{
    /// <summary>
    /// General shares or equity savings account.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_sSL2YF2cEeiFXdiLi_Nf4A")]
    [Description(@"General shares or equity savings account.")]
    ShareSavingsAccount,

    /// <summary>
    /// Any type of general investment account.
    /// Encoded/decoded by serializers as &quot;ANYY&quot;.
    /// </summary>
    [EnumMember(Value = "ANYY")]
    [IsoId("_8neWgJNuEembCsVG-3f_AA")]
    [Description(@"Any type of general investment account.")]
    Any,
}
