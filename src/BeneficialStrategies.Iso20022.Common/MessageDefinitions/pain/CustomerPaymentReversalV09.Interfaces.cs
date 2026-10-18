// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV09 : ICustomerPaymentReversalV09
{
    IGroupHeader88 ICustomerPaymentReversalV09.GroupHeader => GroupHeader;
    IOriginalGroupHeader16 ICustomerPaymentReversalV09.OriginalGroupInformation => OriginalGroupInformation;
    IOriginalPaymentInstruction33? ICustomerPaymentReversalV09.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    ISupplementaryData1? ICustomerPaymentReversalV09.SupplementaryData => SupplementaryData;
}
