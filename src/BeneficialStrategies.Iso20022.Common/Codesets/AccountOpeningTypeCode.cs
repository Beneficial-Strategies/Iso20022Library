// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account to which an account opening request is related, for instance a new account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_keo2gLcYEeKuGrOch6U_ZQ_-1636830227")]
[Description(@"Specifies the type of account to which an account opening request is related, for instance a new account.")]
[Derivations(typeof(AccountOpeningType1Code))]
public enum AccountOpeningTypeCode
{
    /// <summary>
    /// Account request is to open a new account.
    /// Encoded/decoded by serializers as &quot;NEWA&quot;.
    /// </summary>
    [EnumMember(Value = "NEWA")]
    [IsoId("_keyngLcYEeKuGrOch6U_ZQ_1594511368")]
    [Description(@"Account request is to open a new account.")]
    NewAccountOpening,
    
    /// <summary>
    /// Account request is to open a supplementary account, that is, based on an existing account.
    /// Encoded/decoded by serializers as &quot;SUPA&quot;.
    /// </summary>
    [EnumMember(Value = "SUPA")]
    [IsoId("_keyngbcYEeKuGrOch6U_ZQ_1388415397")]
    [Description(@"Account request is to open a supplementary account, that is, based on an existing account.")]
    SupplementaryAccountOpening,
    
}
