// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInstruction2 : ISettlementInstruction2
{
    ICashAccount24? ISettlementInstruction2.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification3Choice? ISettlementInstruction2.ClearingSystem => ClearingSystem;
}
