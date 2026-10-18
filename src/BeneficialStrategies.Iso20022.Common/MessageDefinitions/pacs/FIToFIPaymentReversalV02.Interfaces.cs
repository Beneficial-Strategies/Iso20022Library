// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV02 : IFIToFIPaymentReversalV02
{
    IGroupHeader41 IFIToFIPaymentReversalV02.GroupHeader => GroupHeader;
    IOriginalGroupInformation22 IFIToFIPaymentReversalV02.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransactionInformation29> IFIToFIPaymentReversalV02.TransactionInformation => TransactionInformation;
}
