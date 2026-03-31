// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason for a withdrawal from the investment product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LZZ2wE7bEeifNrXGwadPmg")]
[Description(@"Specifies a reason for a withdrawal from the investment product.")]
[DerivedFrom(typeof(PortfolioWithdrawalReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PortfolioWithdrawalReason1Code>))]
#endif
public enum PortfolioWithdrawalReason1Code
{
    /// <summary>
    /// Withdrawal is for a first time residential property.
    /// Encoded/decoded by serializers as &quot;FTRS&quot;.
    /// </summary>
    [EnumMember(Value = "FTRS")]
    [IsoId("_sp6loV23EeiFXdiLi_Nf4A")]
    [Description(@"Withdrawal is for a first time residential property.||")]
    FirstTimeResidentialProperty = PortfolioWithdrawalReasonCode.FirstTimeResidentialProperty, // same ordinal as derivation source for type conversions
}
