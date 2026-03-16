// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the instruction for which an status is required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5-DjoFSeEeatgN-VQ0eFlQ")]
[Description(@"Specifies the instruction for which an status is required.")]
[DerivedFrom(typeof(AccountManagementTypeCode))]
public enum AccountManagementType3Code
{
    /// <summary>
    /// Refers to an account modification instruction message.
    /// Encoded/decoded by serializers as &quot;ACCM&quot;.
    /// </summary>
    [EnumMember(Value = "ACCM")]
    [IsoId("_Bak_kVSfEeatgN-VQ0eFlQ")]
    [Description(@"Refers to an account modification instruction message.")]
    AccountModification = AccountManagementTypeCode.AccountModification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refers to an account opening instruction message.
    /// Encoded/decoded by serializers as &quot;ACCO&quot;.
    /// </summary>
    [EnumMember(Value = "ACCO")]
    [IsoId("_BxC-0VSfEeatgN-VQ0eFlQ")]
    [Description(@"Refers to an account opening instruction message.")]
    AccountOpening = AccountManagementTypeCode.AccountOpening, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refers to a get account details message.
    /// Encoded/decoded by serializers as &quot;GACC&quot;.
    /// </summary>
    [EnumMember(Value = "GACC")]
    [IsoId("_jN7kUVSqEeatgN-VQ0eFlQ")]
    [Description(@"Refers to a get account details message.")]
    GetAccountDetails = AccountManagementTypeCode.GetAccountDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refers to the account status.
    /// Encoded/decoded by serializers as &quot;ACST&quot;.
    /// </summary>
    [EnumMember(Value = "ACST")]
    [IsoId("_w6yBQaZsEea-RdGKJ0RADA")]
    [Description(@"Refers to the account status.")]
    AccountStatus = AccountManagementTypeCode.AccountStatus, // same ordinal as derivation source for type conversions
}
