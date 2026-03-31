// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a24A8dp-Ed-ak6NoX_4Aeg_2050502101")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashAccountType1Code>))]
#endif
public enum CashAccountType1Code
{
    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as &quot;SACC&quot;.
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a24A8tp-Ed-ak6NoX_4Aeg_2050502103")]
    [Description(
        @"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system."
    )]
    Settlement = CashAccountTypeCode.Settlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a24A89p-Ed-ak6NoX_4Aeg_2050502104")]
    [Description(
        @"Account used to post debits and credits when no specific account has been nominated."
    )]
    Current = CashAccountTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a24A9Np-Ed-ak6NoX_4Aeg_2050502105")]
    [Description(@"Account used for savings.")]
    Savings = CashAccountTypeCode.Savings, // same ordinal as derivation source for type conversions
}
