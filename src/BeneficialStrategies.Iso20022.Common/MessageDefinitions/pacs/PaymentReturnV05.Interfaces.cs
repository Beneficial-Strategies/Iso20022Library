// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV05 : IPaymentReturnV05
{
    IGroupHeader54 IPaymentReturnV05.GroupHeader => GroupHeader;
    IOriginalGroupHeader2? IPaymentReturnV05.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction50? IPaymentReturnV05.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV05.SupplementaryData => SupplementaryData;
}
