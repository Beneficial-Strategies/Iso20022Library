// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.StatementType7Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the statement type.</summary>
    [IsoId("_wEGvUQJ3EfGAP_FOfstLIw")]
    [DisplayName("Statement Type 7 Choice")]
    [KnownType(typeof(StatementType7Choice.Code))]
    [KnownType(typeof(StatementType7Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementType7Choice.Code))]
    [JsonDerivedType(typeof(StatementType7Choice.Proprietary))]
    public abstract record StatementType7Choice_
    {
    }
}
