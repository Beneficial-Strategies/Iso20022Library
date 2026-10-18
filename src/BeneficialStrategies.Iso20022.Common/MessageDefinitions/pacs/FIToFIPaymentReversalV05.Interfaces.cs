// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV05 : IFIToFIPaymentReversalV05
{
    IGroupHeader57 IFIToFIPaymentReversalV05.GroupHeader => GroupHeader;
    IOriginalGroupHeader3? IFIToFIPaymentReversalV05.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransaction51> IFIToFIPaymentReversalV05.TransactionInformation => TransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentReversalV05.SupplementaryData => SupplementaryData;
}
