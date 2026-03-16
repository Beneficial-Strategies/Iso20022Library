// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Refer to an account management instruction ie, either an account opening instruction or an account modification instruction or a get account details message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqvG0tp-Ed-ak6NoX_4Aeg_-845396197")]
[Description(
    @"Refer to an account management instruction ie, either an account opening instruction or an account modification instruction or a get account details message."
)]
[DerivedFrom(typeof(AccountManagementTypeCode))]
public enum AccountManagementType2Code
{
    /// <summary>
    /// Refers to an account opening instruction message.
    /// Encoded/decoded by serializers as &quot;ACCO&quot;.
    /// </summary>
    [EnumMember(Value = "ACCO")]
    [IsoId("_bqvG09p-Ed-ak6NoX_4Aeg_-845396171")]
    [Description(@"Refers to an account opening instruction message.")]
    AccountOpening = AccountManagementTypeCode.AccountOpening, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refers to an account modification instruction message.
    /// Encoded/decoded by serializers as &quot;ACCM&quot;.
    /// </summary>
    [EnumMember(Value = "ACCM")]
    [IsoId("_bqvG1Np-Ed-ak6NoX_4Aeg_-845395920")]
    [Description(@"Refers to an account modification instruction message.")]
    AccountModification = AccountManagementTypeCode.AccountModification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refers to a get account details message.
    /// Encoded/decoded by serializers as &quot;GACC&quot;.
    /// </summary>
    [EnumMember(Value = "GACC")]
    [IsoId("_bqvG1dp-Ed-ak6NoX_4Aeg_-784440543")]
    [Description(@"Refers to a get account details message.")]
    GetAccountDetails = AccountManagementTypeCode.GetAccountDetails, // same ordinal as derivation source for type conversions
}
