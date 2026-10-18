// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV07 : ICustomerPaymentReversalV07
{
    IGroupHeader56 ICustomerPaymentReversalV07.GroupHeader => GroupHeader;
    IOriginalGroupHeader3 ICustomerPaymentReversalV07.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction21? ICustomerPaymentReversalV07.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV07.SupplementaryData => SupplementaryData;
}
