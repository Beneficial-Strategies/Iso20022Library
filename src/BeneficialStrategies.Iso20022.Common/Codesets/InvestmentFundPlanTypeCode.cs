// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifes a type of investment fund plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sH2IUF9BEeicg40_9gK9vQ")]
[Description(@"Specifes a type of investment fund plan.")]
[Derivations(typeof(InvestmentFundPlanType1Code))]
public enum InvestmentFundPlanTypeCode
{
    /// <summary>
    /// Savings investment plan.
    /// Encoded/decoded by serializers as &quot;INVP&quot;.
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_xwSXgF9BEeicg40_9gK9vQ")]
    [Description(@"Savings investment plan.")]
    SavingsInvestmentPlan,
    
    /// <summary>
    /// Withdrawal plan.
    /// Encoded/decoded by serializers as &quot;WTHP&quot;.
    /// </summary>
    [EnumMember(Value = "WTHP")]
    [IsoId("_0aRRgF9BEeicg40_9gK9vQ")]
    [Description(@"Withdrawal plan.")]
    WithdrawalPlan,
    
    /// <summary>
    /// Switch plan.
    /// Encoded/decoded by serializers as &quot;SWIP&quot;.
    /// </summary>
    [EnumMember(Value = "SWIP")]
    [IsoId("_2F9XQF9BEeicg40_9gK9vQ")]
    [Description(@"Switch plan.")]
    SwitchPlan,
    
}
