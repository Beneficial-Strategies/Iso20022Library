// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV08 : IFIToFIPaymentReversalV08
{
    IGroupHeader71 IFIToFIPaymentReversalV08.GroupHeader => GroupHeader;
    IOriginalGroupHeader11? IFIToFIPaymentReversalV08.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction88? IFIToFIPaymentReversalV08.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentReversalV08.SupplementaryData => SupplementaryData;
}
