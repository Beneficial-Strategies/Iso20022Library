// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV13 : IPaymentReturnV13
{
    IGroupHeader123 IPaymentReturnV13.GroupHeader => GroupHeader;
    IOriginalGroupHeader19? IPaymentReturnV13.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<ISupplementaryData1> IPaymentReturnV13.SupplementaryData => SupplementaryData;
    IEnumerable<IPaymentTransaction159> IPaymentReturnV13.TransactionInformation => TransactionInformation;
}
