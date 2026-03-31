// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account to which an account opening request is related, eg, a new account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bq4Qwdp-Ed-ak6NoX_4Aeg_-1409903873")]
[Description(
    @"Specifies the type of account to which an account opening request is related, eg, a new account."
)]
[DerivedFrom(typeof(AccountOpeningTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountOpeningType1Code>))]
#endif
public enum AccountOpeningType1Code
{
    /// <summary>
    /// Account request is to open a new account.
    /// Encoded/decoded by serializers as &quot;NEWA&quot;.
    /// </summary>
    [EnumMember(Value = "NEWA")]
    [IsoId("_bq4Qwtp-Ed-ak6NoX_4Aeg_-1409903872")]
    [Description(@"Account request is to open a new account.")]
    NewAccountOpening = AccountOpeningTypeCode.NewAccountOpening, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account request is to open a supplementary account, that is, based on an existing account.
    /// Encoded/decoded by serializers as &quot;SUPA&quot;.
    /// </summary>
    [EnumMember(Value = "SUPA")]
    [IsoId("_bq4Qw9p-Ed-ak6NoX_4Aeg_-1409903871")]
    [Description(
        @"Account request is to open a supplementary account, that is, based on an existing account."
    )]
    SupplementaryAccountOpening = AccountOpeningTypeCode.SupplementaryAccountOpening, // same ordinal as derivation source for type conversions
}
