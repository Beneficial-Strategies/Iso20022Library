// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV06 : ICustomerPaymentReversalV06
{
    IGroupHeader56 ICustomerPaymentReversalV06.GroupHeader => GroupHeader;
    IOriginalGroupHeader3 ICustomerPaymentReversalV06.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction16? ICustomerPaymentReversalV06.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV06.SupplementaryData => SupplementaryData;
}
