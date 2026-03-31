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
[IsoId("_yNcYIBRHEeOKWo1NF21OVw")]
[Description(@"Specifies the investment account category.")]
[Derivations(typeof(InvestmentAccountCategory1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestmentAccountCategoryCode>))]
#endif
public enum InvestmentAccountCategoryCode
{
    /// <summary>
    /// Account is a standard account managed by the investor. The investor issues instructions for the account to the financial institution.
    /// Encoded/decoded by serializers as &quot;RETA&quot;.
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_32N-gBRHEeOKWo1NF21OVw")]
    [Description(
        @"Account is a standard account managed by the investor. The investor issues instructions for the account to the financial institution."
    )]
    RetailAccount,

    /// <summary>
    /// Account is fully managed by the financial institution, that is, an investor gives a &apos;mandate&apos; to the financial institution to execute a mutually agreed investment strategy on its behalf.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_35MaABRHEeOKWo1NF21OVw")]
    [Description(
        @"Account is fully managed by the financial institution, that is, an investor gives a 'mandate' to the financial institution to execute a mutually agreed investment strategy on its behalf."
    )]
    MandateAccount,
}
