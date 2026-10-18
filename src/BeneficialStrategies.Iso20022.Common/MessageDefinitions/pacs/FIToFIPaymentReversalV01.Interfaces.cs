// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV01 : IFIToFIPaymentReversalV01
{
    IGroupHeader9 IFIToFIPaymentReversalV01.GroupHeader => GroupHeader;
    IOriginalGroupInformation5 IFIToFIPaymentReversalV01.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransactionInformation5> IFIToFIPaymentReversalV01.TransactionInformation => TransactionInformation;
}
