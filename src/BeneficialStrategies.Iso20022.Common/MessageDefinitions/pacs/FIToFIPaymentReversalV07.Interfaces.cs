// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV07 : IFIToFIPaymentReversalV07
{
    IGroupHeader71 IFIToFIPaymentReversalV07.GroupHeader => GroupHeader;
    IOriginalGroupHeader3? IFIToFIPaymentReversalV07.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransaction81> IFIToFIPaymentReversalV07.TransactionInformation => TransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentReversalV07.SupplementaryData => SupplementaryData;
}
