// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investment account category.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FWTfYBRIEeOKWo1NF21OVw")]
[Description(@"Specifies the investment account category.")]
[DerivedFrom(typeof(InvestmentAccountCategoryCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestmentAccountCategory1Code>))]
#endif
public enum InvestmentAccountCategory1Code
{
    /// <summary>
    /// Account is fully managed by the financial institution, that is, an investor gives a &apos;mandate&apos; to the financial institution to execute a mutually agreed investment strategy on its behalf.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_HQJ88RRIEeOKWo1NF21OVw")]
    [Description(
        @"Account is fully managed by the financial institution, that is, an investor gives a 'mandate' to the financial institution to execute a mutually agreed investment strategy on its behalf."
    )]
    MandateAccount = InvestmentAccountCategoryCode.MandateAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is a standard account managed by the investor. The investor issues instructions for the account to the financial institution.
    /// Encoded/decoded by serializers as &quot;RETA&quot;.
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_HZh7YRRIEeOKWo1NF21OVw")]
    [Description(
        @"Account is a standard account managed by the investor. The investor issues instructions for the account to the financial institution."
    )]
    RetailAccount = InvestmentAccountCategoryCode.RetailAccount, // same ordinal as derivation source for type conversions
}
