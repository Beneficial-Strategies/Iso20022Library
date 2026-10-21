// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.MovementRecord2.Valid;

/// <summary>Valid samples of <c>MovementRecord2</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>MovementRecord2</c> with the required members set. A new object on every access.</summary>
    public static Components.IMovementRecord2 Minimal =>
        IsoDataFactory.Make<IMovementRecord2>(b => b
            .Set(x => x.Identification).To("MOV-001")
            .Set(x => x.Amount).To(Samples.AmountAndDirection5.Valid.Standard.Minimal));
}
