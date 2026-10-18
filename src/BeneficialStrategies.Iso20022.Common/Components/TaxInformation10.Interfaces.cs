// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TaxInformation10 : ITaxInformation10
{
    ITaxParty1? ITaxInformation10.Creditor => Creditor;
    ITaxParty2? ITaxInformation10.Debtor => Debtor;
    IEnumerable<ITaxRecord3> ITaxInformation10.Record => Record;
}
