// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.MultilateralSettlementRequest3.Valid;

/// <summary>Valid samples of <c>MultilateralSettlementRequest3</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>MultilateralSettlementRequest3</c> with the required members set. A new object on every access.</summary>
    public static Components.IMultilateralSettlementRequest3 Minimal =>
        IsoDataFactory.Make<IMultilateralSettlementRequest3>(b => b
            .Set(x => x.InstructionIdentification).To("INSTR-001")
            .Set(x => x.MovementRecord).To([Samples.MovementRecord2.Valid.Standard.Minimal]));
}
