// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV12 : ICustomerPaymentStatusReportV12
{
    IGroupHeader86 ICustomerPaymentStatusReportV12.GroupHeader => GroupHeader;
    IOriginalGroupHeader17 ICustomerPaymentStatusReportV12.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction40? ICustomerPaymentStatusReportV12.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV12.SupplementaryData => SupplementaryData;
}
