// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV12 : IPaymentReturnV12
{
    IGroupHeader99 IPaymentReturnV12.GroupHeader => GroupHeader;
    IOriginalGroupHeader18? IPaymentReturnV12.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction146? IPaymentReturnV12.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV12.SupplementaryData => SupplementaryData;
}
