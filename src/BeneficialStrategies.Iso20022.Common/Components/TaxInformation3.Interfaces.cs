// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxInformation3 : ITaxInformation3
{
    ITaxParty1? ITaxInformation3.Creditor => Creditor;
    ITaxParty2? ITaxInformation3.Debtor => Debtor;
    IEnumerable<ITaxRecord1> ITaxInformation3.Record => Record;
}
