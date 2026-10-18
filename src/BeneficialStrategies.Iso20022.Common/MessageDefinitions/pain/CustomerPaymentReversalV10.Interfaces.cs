// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV10 : ICustomerPaymentReversalV10
{
    IGroupHeader88 ICustomerPaymentReversalV10.GroupHeader => GroupHeader;
    IOriginalGroupHeader16 ICustomerPaymentReversalV10.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction37? ICustomerPaymentReversalV10.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV10.SupplementaryData => SupplementaryData;
}
