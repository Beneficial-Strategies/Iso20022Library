// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV06 : IPaymentReturnV06
{
    IGroupHeader72 IPaymentReturnV06.GroupHeader => GroupHeader;
    IOriginalGroupHeader2? IPaymentReturnV06.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction65? IPaymentReturnV06.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV06.SupplementaryData => SupplementaryData;
}
