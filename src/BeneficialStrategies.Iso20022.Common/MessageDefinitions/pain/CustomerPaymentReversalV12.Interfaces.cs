// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV12 : ICustomerPaymentReversalV12
{
    IGroupHeader124 ICustomerPaymentReversalV12.GroupHeader => GroupHeader;
    IOriginalGroupHeader20 ICustomerPaymentReversalV12.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IOriginalPaymentInstruction50> ICustomerPaymentReversalV12.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    IEnumerable<ISupplementaryData1> ICustomerPaymentReversalV12.SupplementaryData => SupplementaryData;
}
