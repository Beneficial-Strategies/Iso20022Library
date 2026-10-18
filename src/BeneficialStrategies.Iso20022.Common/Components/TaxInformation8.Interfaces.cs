// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxInformation8 : ITaxInformation8
{
    ITaxParty1? ITaxInformation8.Creditor => Creditor;
    ITaxParty2? ITaxInformation8.Debtor => Debtor;
    IEnumerable<ITaxRecord2> ITaxInformation8.Record => Record;
}
