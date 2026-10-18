// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV03 : ICustomerPaymentReversalV03
{
    IGroupHeader56 ICustomerPaymentReversalV03.GroupHeader => GroupHeader;
    IOriginalGroupHeader3 ICustomerPaymentReversalV03.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction2? ICustomerPaymentReversalV03.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV03.SupplementaryData => SupplementaryData;
}
