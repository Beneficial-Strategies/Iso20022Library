// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV01 : IPaymentReturnV01
{
    IGroupHeader6 IPaymentReturnV01.GroupHeader => GroupHeader;
    IOriginalGroupInformation2? IPaymentReturnV01.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransactionInformation2> IPaymentReturnV01.TransactionInformation => TransactionInformation;
}
