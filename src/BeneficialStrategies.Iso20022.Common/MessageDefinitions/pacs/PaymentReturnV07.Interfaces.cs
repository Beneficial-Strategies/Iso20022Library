// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV07 : IPaymentReturnV07
{
    IGroupHeader72 IPaymentReturnV07.GroupHeader => GroupHeader;
    IOriginalGroupHeader2? IPaymentReturnV07.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction76? IPaymentReturnV07.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV07.SupplementaryData => SupplementaryData;
}
