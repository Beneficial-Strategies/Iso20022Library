// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TransactionAllocation1 : ITransactionAllocation1
{
    ICashAccount40 ITransactionAllocation1.Account => Account;
    IPurpose2Choice ITransactionAllocation1.Purpose => Purpose;
    IEnumerable<IReferences74Choice> ITransactionAllocation1.RelatedReferences => RelatedReferences;
}
