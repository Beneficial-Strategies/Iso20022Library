// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInformation2 : ISettlementInformation2
{
    ICashAccount7? ISettlementInformation2.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification1Choice? ISettlementInformation2.ClearingSystem => ClearingSystem;
}
