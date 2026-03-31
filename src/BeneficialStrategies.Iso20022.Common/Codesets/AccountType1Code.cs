// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_brn3ptp-Ed-ak6NoX_4Aeg_-1407974386")]
[Description(@"Specifies the type of account.")]
[DerivedFrom(typeof(AccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountType1Code>))]
#endif
public enum AccountType1Code
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_brn3p9p-Ed-ak6NoX_4Aeg_-1349793499")]
    [Description(@"Cash account.")]
    Cash = AccountTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities account.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_brn3qNp-Ed-ak6NoX_4Aeg_-1327628324")]
    [Description(@"Securities account.")]
    Securities = AccountTypeCode.Securities, // same ordinal as derivation source for type conversions
}
