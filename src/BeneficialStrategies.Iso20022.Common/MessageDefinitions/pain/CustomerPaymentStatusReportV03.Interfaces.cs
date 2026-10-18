// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV03 : ICustomerPaymentStatusReportV03
{
    IGroupHeader36 ICustomerPaymentStatusReportV03.GroupHeader => GroupHeader;
    IOriginalGroupInformation20 ICustomerPaymentStatusReportV03.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInformation1? ICustomerPaymentStatusReportV03.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
}
