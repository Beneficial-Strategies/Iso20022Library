// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentReversalV13 : ICustomerPaymentReversalV13
{
    IGroupHeader124 ICustomerPaymentReversalV13.GroupHeader => GroupHeader;
    IOriginalGroupHeader20 ICustomerPaymentReversalV13.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IOriginalPaymentInstruction53> ICustomerPaymentReversalV13.OriginalPaymentInformationAndReversal => OriginalPaymentInformationAndReversal;
    IEnumerable<ISupplementaryData1> ICustomerPaymentReversalV13.SupplementaryData => SupplementaryData;
}
