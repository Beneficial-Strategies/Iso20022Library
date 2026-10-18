// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TransactionAllocation2 : ITransactionAllocation2
{
    ICashAccount40 ITransactionAllocation2.Account => Account;
    IPurpose2Choice ITransactionAllocation2.Purpose => Purpose;
    IEnumerable<IReferences80Choice> ITransactionAllocation2.RelatedReferences => RelatedReferences;
}
