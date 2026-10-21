// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.MultilateralSettlementRequestV02.Valid;

/// <summary>Valid samples of <c>MultilateralSettlementRequestV02</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>MultilateralSettlementRequestV02</c> with the required members set. A new object on every access.</summary>
    public static pacs.IMultilateralSettlementRequestV02 Minimal =>
        IsoDataFactory.Make<IMultilateralSettlementRequestV02>(b => b
            .Set(x => x.GroupHeader).To(Samples.GroupHeader104.Valid.Standard.Minimal)
            .Set(x => x.SettlementRequest).To([Samples.MultilateralSettlementRequest3.Valid.Standard.Minimal]));
}
