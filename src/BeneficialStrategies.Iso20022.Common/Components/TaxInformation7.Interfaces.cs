// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxInformation7 : ITaxInformation7
{
    ITaxParty1? ITaxInformation7.Creditor => Creditor;
    ITaxParty2? ITaxInformation7.Debtor => Debtor;
    ITaxParty2? ITaxInformation7.UltimateDebtor => UltimateDebtor;
    IEnumerable<ITaxRecord2> ITaxInformation7.Record => Record;
}
