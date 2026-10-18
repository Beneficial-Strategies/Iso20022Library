// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV11 : ICustomerPaymentReversalV11
{
    IGroupHeader88 ICustomerPaymentReversalV11.GroupHeader => GroupHeader;
    IOriginalGroupHeader16 ICustomerPaymentReversalV11.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction41? ICustomerPaymentReversalV11.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV11.SupplementaryData => SupplementaryData;
}
