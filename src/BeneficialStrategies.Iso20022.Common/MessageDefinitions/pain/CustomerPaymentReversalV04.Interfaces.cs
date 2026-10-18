// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV04 : ICustomerPaymentReversalV04
{
    IGroupHeader56 ICustomerPaymentReversalV04.GroupHeader => GroupHeader;
    IOriginalGroupHeader3 ICustomerPaymentReversalV04.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction7? ICustomerPaymentReversalV04.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV04.SupplementaryData => SupplementaryData;
}
