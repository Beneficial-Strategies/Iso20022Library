// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV10 : IPaymentReturnV10
{
    IGroupHeader90 IPaymentReturnV10.GroupHeader => GroupHeader;
    IOriginalGroupHeader18? IPaymentReturnV10.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction118? IPaymentReturnV10.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV10.SupplementaryData => SupplementaryData;
}
