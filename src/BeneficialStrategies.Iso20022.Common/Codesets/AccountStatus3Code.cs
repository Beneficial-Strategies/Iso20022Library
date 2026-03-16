// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies further the current state of an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yajvgdp-Ed-ak6NoX_4Aeg_-2144762850")]
[Description(@"Qualifies further the current state of an account.")]
[DerivedFrom(typeof(AccountStatusCode))]
public enum AccountStatus3Code
{
    /// <summary>
    /// Account can be used for its intended purpose.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_Yajvgtp-Ed-ak6NoX_4Aeg_-2072727728")]
    [Description(@"Account can be used for its intended purpose.")]
    Enabled = AccountStatusCode.Enabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account cannot be used for its intended purpose, either temporarily or permanently.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_Yajvg9p-Ed-ak6NoX_4Aeg_-2045022067")]
    [Description(
        @"Account cannot be used for its intended purpose, either temporarily or permanently."
    )]
    Disabled = AccountStatusCode.Disabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account cannot be used any longer.
    /// Encoded/decoded by serializers as &quot;DELE&quot;.
    /// </summary>
    [EnumMember(Value = "DELE")]
    [IsoId("_YajvhNp-Ed-ak6NoX_4Aeg_-2017316036")]
    [Description(@"Account cannot be used any longer.")]
    Deleted = AccountStatusCode.Deleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.
    /// Encoded/decoded by serializers as &quot;FORM&quot;.
    /// </summary>
    [EnumMember(Value = "FORM")]
    [IsoId("_Yajvhdp-Ed-ak6NoX_4Aeg_-1757807861")]
    [Description(
        @"Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents."
    )]
    ProForma = AccountStatusCode.ProForma, // same ordinal as derivation source for type conversions
}
