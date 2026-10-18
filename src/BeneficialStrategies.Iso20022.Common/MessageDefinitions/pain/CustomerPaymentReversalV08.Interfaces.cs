// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV08 : ICustomerPaymentReversalV08
{
    IGroupHeader75 ICustomerPaymentReversalV08.GroupHeader => GroupHeader;
    IOriginalGroupHeader11 ICustomerPaymentReversalV08.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction28? ICustomerPaymentReversalV08.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV08.SupplementaryData => SupplementaryData;
}
