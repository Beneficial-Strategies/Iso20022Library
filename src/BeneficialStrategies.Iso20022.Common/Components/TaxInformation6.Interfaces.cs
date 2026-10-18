// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxInformation6 : ITaxInformation6
{
    ITaxParty1? ITaxInformation6.Creditor => Creditor;
    ITaxParty2? ITaxInformation6.Debtor => Debtor;
    IEnumerable<ITaxRecord2> ITaxInformation6.Record => Record;
}
