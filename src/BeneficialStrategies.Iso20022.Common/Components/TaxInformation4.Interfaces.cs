// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxInformation4 : ITaxInformation4
{
    ITaxParty1? ITaxInformation4.Creditor => Creditor;
    ITaxParty2? ITaxInformation4.Debtor => Debtor;
    ITaxParty2? ITaxInformation4.UltimateDebtor => UltimateDebtor;
    IEnumerable<ITaxRecord1> ITaxInformation4.Record => Record;
}
