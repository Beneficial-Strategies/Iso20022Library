// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV13 : IFIToFIPaymentReversalV13
{
    IGroupHeader127 IFIToFIPaymentReversalV13.GroupHeader => GroupHeader;
    IOriginalGroupHeader20? IFIToFIPaymentReversalV13.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentReversalV13.SupplementaryData => SupplementaryData;
    IEnumerable<IPaymentTransaction149> IFIToFIPaymentReversalV13.TransactionInformation => TransactionInformation;
}
