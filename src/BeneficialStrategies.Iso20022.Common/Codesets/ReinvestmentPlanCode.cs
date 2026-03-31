// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the specific reinvestment plan type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tyUxkVf8EeOuDtoQo1qilA")]
[Description(@"Indicates the specific reinvestment plan type.")]
[Derivations(typeof(ReinvestmentPlan1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReinvestmentPlanCode>))]
#endif
public enum ReinvestmentPlanCode
{
    /// <summary>
    /// Reinvestment plan is for retail investors only.
    /// Encoded/decoded by serializers as &quot;RETA&quot;.
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_0FXc8Ff8EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is for retail investors only.")]
    ForRetailInvestorsOnly,

    /// <summary>
    /// Full reinvestment plan offered.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_6eN1YFf8EeOuDtoQo1qilA")]
    [Description(@"Full reinvestment plan offered.")]
    FullReinvestmentPlanOffered,

    /// <summary>
    /// Reinvestment plan is subject to shareholder approval.
    /// Encoded/decoded by serializers as &quot;SUAP&quot;.
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("__Q_n4Ff8EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is subject to shareholder approval.")]
    SubjectToShareholderApproval,
}
