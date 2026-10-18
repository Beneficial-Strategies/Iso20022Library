// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MultilateralSettlementRequest2 : IMultilateralSettlementRequest2
{
    ISettlementTimeRequest2? IMultilateralSettlementRequest2.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<IMovementRecord1> IMultilateralSettlementRequest2.MovementRecord => MovementRecord;
}
