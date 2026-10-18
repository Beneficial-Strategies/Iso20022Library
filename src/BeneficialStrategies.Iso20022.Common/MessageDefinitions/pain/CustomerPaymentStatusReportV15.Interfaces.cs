// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV15 : ICustomerPaymentStatusReportV15
{
    IGroupHeader128 ICustomerPaymentStatusReportV15.GroupHeader => GroupHeader;
    IOriginalGroupHeader22 ICustomerPaymentStatusReportV15.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IOriginalPaymentInstruction56> ICustomerPaymentStatusReportV15.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    IEnumerable<ISupplementaryData1> ICustomerPaymentStatusReportV15.SupplementaryData => SupplementaryData;
}
