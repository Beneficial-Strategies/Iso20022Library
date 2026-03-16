// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Refer to an account management instruction ie, either an account opening instruction or an account modification instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqlV2Np-Ed-ak6NoX_4Aeg_1424424749")]
[Description(
    @"Refer to an account management instruction ie, either an account opening instruction or an account modification instruction."
)]
[DerivedFrom(typeof(AccountManagementTypeCode))]
public enum AccountManagementType1Code
{
    /// <summary>
    /// Refers to an account opening instruction message.
    /// Encoded/decoded by serializers as &quot;ACCO&quot;.
    /// </summary>
    [EnumMember(Value = "ACCO")]
    [IsoId("_bqvG0Np-Ed-ak6NoX_4Aeg_1776286854")]
    [Description(@"Refers to an account opening instruction message.")]
    AccountOpening = AccountManagementTypeCode.AccountOpening, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Refers to an account modification instruction message.
    /// Encoded/decoded by serializers as &quot;ACCM&quot;.
    /// </summary>
    [EnumMember(Value = "ACCM")]
    [IsoId("_bqvG0dp-Ed-ak6NoX_4Aeg_1776286907")]
    [Description(@"Refers to an account modification instruction message.")]
    AccountModification = AccountManagementTypeCode.AccountModification, // same ordinal as derivation source for type conversions
}
