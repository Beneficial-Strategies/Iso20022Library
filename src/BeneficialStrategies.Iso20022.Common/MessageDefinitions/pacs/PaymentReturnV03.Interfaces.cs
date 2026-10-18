// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV03 : IPaymentReturnV03
{
    IGroupHeader54 IPaymentReturnV03.GroupHeader => GroupHeader;
    IOriginalGroupHeader2? IPaymentReturnV03.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction34? IPaymentReturnV03.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV03.SupplementaryData => SupplementaryData;
}
