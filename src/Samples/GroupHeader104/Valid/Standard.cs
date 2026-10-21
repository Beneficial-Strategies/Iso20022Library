// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.GroupHeader104.Valid;

/// <summary>Valid samples of <c>GroupHeader104</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>GroupHeader104</c> with the required members set. A new object on every access.</summary>
    public static Components.IGroupHeader104 Minimal =>
        IsoDataFactory.Make<IGroupHeader104>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfSettlementRequests).To("1"));
}
