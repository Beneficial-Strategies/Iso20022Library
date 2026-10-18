// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV14 : IFIToFIPaymentReversalV14
{
    IGroupHeader127 IFIToFIPaymentReversalV14.GroupHeader => GroupHeader;
    IOriginalGroupHeader20? IFIToFIPaymentReversalV14.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentReversalV14.SupplementaryData => SupplementaryData;
    IEnumerable<IPaymentTransaction182> IFIToFIPaymentReversalV14.TransactionInformation => TransactionInformation;
}
