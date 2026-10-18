// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV09 : IFIToFIPaymentReversalV09
{
    IGroupHeader89 IFIToFIPaymentReversalV09.GroupHeader => GroupHeader;
    IOriginalGroupHeader16? IFIToFIPaymentReversalV09.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction111? IFIToFIPaymentReversalV09.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentReversalV09.SupplementaryData => SupplementaryData;
}
