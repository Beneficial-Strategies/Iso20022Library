// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV01 : ICustomerPaymentReversalV01
{
    IGroupHeader8 ICustomerPaymentReversalV01.GroupHeader => GroupHeader;
    IOriginalGroupInformation5 ICustomerPaymentReversalV01.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransactionInformation4? ICustomerPaymentReversalV01.TransactionInformation => TransactionInformation;
}
