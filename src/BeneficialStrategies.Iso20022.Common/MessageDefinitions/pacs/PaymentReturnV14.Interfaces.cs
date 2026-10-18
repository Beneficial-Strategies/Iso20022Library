// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV14 : IPaymentReturnV14
{
    IGroupHeader123 IPaymentReturnV14.GroupHeader => GroupHeader;
    IOriginalGroupHeader19? IPaymentReturnV14.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransaction163> IPaymentReturnV14.TransactionInformation => TransactionInformation;
    IEnumerable<ISupplementaryData1> IPaymentReturnV14.SupplementaryData => SupplementaryData;
}
