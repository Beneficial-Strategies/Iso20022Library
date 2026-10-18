// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentCancellationRequestV01 : IPaymentCancellationRequestV01
{
    IGroupHeader7 IPaymentCancellationRequestV01.GroupHeader => GroupHeader;
    IOriginalGroupInformation4 IPaymentCancellationRequestV01.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransactionInformation3> IPaymentCancellationRequestV01.TransactionInformation => TransactionInformation;
}
