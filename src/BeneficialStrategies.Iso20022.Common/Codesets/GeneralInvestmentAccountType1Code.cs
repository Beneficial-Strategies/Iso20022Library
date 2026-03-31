// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of investment account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bk_q4F2dEeiFXdiLi_Nf4A")]
[Description(@"Specifies a type of investment account.")]
[DerivedFrom(typeof(GeneralInvestmentAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<GeneralInvestmentAccountType1Code>))]
#endif
public enum GeneralInvestmentAccountType1Code
{
    /// <summary>
    /// General shares or equity savings account.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_dqv2cV2dEeiFXdiLi_Nf4A")]
    [Description(@"General shares or equity savings account.")]
    ShareSavingsAccount = GeneralInvestmentAccountTypeCode.ShareSavingsAccount, // same ordinal as derivation source for type conversions
}
