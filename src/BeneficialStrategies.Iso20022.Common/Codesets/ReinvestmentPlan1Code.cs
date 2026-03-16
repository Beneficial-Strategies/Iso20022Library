// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the specific reinvestment plan type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_INWe4Ff9EeOuDtoQo1qilA")]
[Description(@"Indicates the specific reinvestment plan type.")]
[DerivedFrom(typeof(ReinvestmentPlanCode))]
public enum ReinvestmentPlan1Code
{
    /// <summary>
    /// Reinvestment plan is for retail investors only.
    /// Encoded/decoded by serializers as &quot;RETA&quot;.
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_Jc8egVf9EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is for retail investors only.")]
    ForRetailInvestorsOnly = ReinvestmentPlanCode.ForRetailInvestorsOnly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full reinvestment plan offered.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_JkiUQVf9EeOuDtoQo1qilA")]
    [Description(@"Full reinvestment plan offered.")]
    FullReinvestmentPlanOffered = ReinvestmentPlanCode.FullReinvestmentPlanOffered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reinvestment plan is subject to shareholder approval.
    /// Encoded/decoded by serializers as &quot;SUAP&quot;.
    /// </summary>
    [EnumMember(Value = "SUAP")]
    [IsoId("_JuNNoVf9EeOuDtoQo1qilA")]
    [Description(@"Reinvestment plan is subject to shareholder approval.")]
    SubjectToShareholderApproval = ReinvestmentPlanCode.SubjectToShareholderApproval, // same ordinal as derivation source for type conversions
}
