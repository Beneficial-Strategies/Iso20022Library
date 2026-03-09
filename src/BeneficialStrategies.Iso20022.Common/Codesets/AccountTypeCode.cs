// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_brxooNp-Ed-ak6NoX_4Aeg_-1139230209")]
[Description(@"Specifies the type of account.")]
[Derivations(typeof(AccountType1Code))]
public enum AccountTypeCode
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_brxoodp-Ed-ak6NoX_4Aeg_-841858447")]
    [Description(@"Cash account.")]
    Cash,
    
    /// <summary>
    /// Securities account.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_brxootp-Ed-ak6NoX_4Aeg_-841858438")]
    [Description(@"Securities account.")]
    Securities,
    
}
