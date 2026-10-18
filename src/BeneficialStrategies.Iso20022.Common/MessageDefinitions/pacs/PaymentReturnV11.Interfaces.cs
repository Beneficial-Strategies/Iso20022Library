// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV11 : IPaymentReturnV11
{
    IGroupHeader99 IPaymentReturnV11.GroupHeader => GroupHeader;
    IOriginalGroupHeader18? IPaymentReturnV11.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction133? IPaymentReturnV11.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV11.SupplementaryData => SupplementaryData;
}
