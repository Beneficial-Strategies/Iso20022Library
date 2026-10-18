// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV03 : IFIToFIPaymentReversalV03
{
    IGroupHeader57 IFIToFIPaymentReversalV03.GroupHeader => GroupHeader;
    IOriginalGroupHeader3 IFIToFIPaymentReversalV03.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction36? IFIToFIPaymentReversalV03.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentReversalV03.SupplementaryData => SupplementaryData;
}
