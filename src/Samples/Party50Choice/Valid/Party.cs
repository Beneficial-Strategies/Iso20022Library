// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.Party50Choice.Valid;

/// <summary>Valid samples of <c>Party</c> of <c>Party50Choice</c>.</summary>
public static class Party
{
    /// <summary>A valid <c>Party</c> of <c>Party50Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.Party50Choice.IParty Minimal =>
        IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
                .Set(x => x.Value).To(Samples.PartyIdentification272.Valid.Standard.Minimal));
}
