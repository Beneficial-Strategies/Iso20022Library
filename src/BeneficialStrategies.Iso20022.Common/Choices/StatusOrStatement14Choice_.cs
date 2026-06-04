// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.StatusOrStatement14Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a status advice and a statement.</summary>
    [IsoId("_JdxrwaowEfCG2_q2WT-90w")]
    [DisplayName("Status Or Statement 14 Choice")]
    [KnownType(typeof(StatusOrStatement14Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement14Choice.Statement))]
    [JsonDerivedType(typeof(StatusOrStatement14Choice.StatusAdvice))]
    [JsonDerivedType(typeof(StatusOrStatement14Choice.Statement))]
    public abstract record StatusOrStatement14Choice_
    {
    }
}
