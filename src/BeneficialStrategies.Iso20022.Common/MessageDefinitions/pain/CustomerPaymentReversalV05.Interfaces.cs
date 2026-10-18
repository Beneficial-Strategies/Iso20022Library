// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV05 : ICustomerPaymentReversalV05
{
    IGroupHeader56 ICustomerPaymentReversalV05.GroupHeader => GroupHeader;
    IOriginalGroupHeader3 ICustomerPaymentReversalV05.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction11? ICustomerPaymentReversalV05.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV05.SupplementaryData => SupplementaryData;
}
