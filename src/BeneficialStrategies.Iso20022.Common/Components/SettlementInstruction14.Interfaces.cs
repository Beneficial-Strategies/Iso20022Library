// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInstruction14 : ISettlementInstruction14
{
    ICashAccount40? ISettlementInstruction14.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification3Choice? ISettlementInstruction14.ClearingSystem => ClearingSystem;
}
