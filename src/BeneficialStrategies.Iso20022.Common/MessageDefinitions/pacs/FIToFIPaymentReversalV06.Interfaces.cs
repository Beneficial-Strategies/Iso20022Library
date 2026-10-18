// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV06 : IFIToFIPaymentReversalV06
{
    IGroupHeader71 IFIToFIPaymentReversalV06.GroupHeader => GroupHeader;
    IOriginalGroupHeader3? IFIToFIPaymentReversalV06.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction60? IFIToFIPaymentReversalV06.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentReversalV06.SupplementaryData => SupplementaryData;
}
