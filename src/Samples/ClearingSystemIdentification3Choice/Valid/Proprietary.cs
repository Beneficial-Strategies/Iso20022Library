// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.ClearingSystemIdentification3Choice.Valid;

/// <summary>Valid samples of <c>Proprietary</c> of <c>ClearingSystemIdentification3Choice</c>.</summary>
public static class Proprietary
{
    /// <summary>A valid <c>Proprietary</c> of <c>ClearingSystemIdentification3Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.ClearingSystemIdentification3Choice.IProprietary Minimal =>
        IsoDataFactory.Make<Choices.ClearingSystemIdentification3Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYSYS"));
}
