// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV10 : IFIToFIPaymentReversalV10
{
    IGroupHeader89 IFIToFIPaymentReversalV10.GroupHeader => GroupHeader;
    IOriginalGroupHeader16? IFIToFIPaymentReversalV10.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction119? IFIToFIPaymentReversalV10.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentReversalV10.SupplementaryData => SupplementaryData;
}
