// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInstruction8 : ISettlementInstruction8
{
    ICashAccount38? ISettlementInstruction8.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification3Choice? ISettlementInstruction8.ClearingSystem => ClearingSystem;
}
