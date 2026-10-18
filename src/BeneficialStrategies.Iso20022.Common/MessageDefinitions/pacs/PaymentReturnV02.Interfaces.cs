// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV02 : IPaymentReturnV02
{
    IGroupHeader38 IPaymentReturnV02.GroupHeader => GroupHeader;
    IOriginalGroupInformation21? IPaymentReturnV02.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransactionInformation27> IPaymentReturnV02.TransactionInformation => TransactionInformation;
}
