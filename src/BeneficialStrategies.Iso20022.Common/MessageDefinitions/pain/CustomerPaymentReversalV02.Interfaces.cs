// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV02 : ICustomerPaymentReversalV02
{
    IGroupHeader40 ICustomerPaymentReversalV02.GroupHeader => GroupHeader;
    IOriginalGroupInformation22 ICustomerPaymentReversalV02.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInformation2? ICustomerPaymentReversalV02.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
}
