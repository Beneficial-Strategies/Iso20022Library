// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of investment account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HO62UJNvEembCsVG-3f_AA")]
[Description(@"Specifies a type of investment account.")]
[DerivedFrom(typeof(GeneralInvestmentAccountTypeCode))]
public enum GeneralInvestmentAccountType2Code
{
    /// <summary>
    /// Any type of general investment account.
    /// Encoded/decoded by serializers as &quot;ANYY&quot;.
    /// </summary>
    [EnumMember(Value = "ANYY")]
    [IsoId("_PDJ8YZgJEemu1vK8dsrXIw")]
    [Description(@"Any type of general investment account.")]
    Any = GeneralInvestmentAccountTypeCode.Any, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// General shares or equity savings account.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_PI9CYZgJEemu1vK8dsrXIw")]
    [Description(@"General shares or equity savings account.")]
    ShareSavingsAccount = GeneralInvestmentAccountTypeCode.ShareSavingsAccount, // same ordinal as derivation source for type conversions
    
}
