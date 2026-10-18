// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV01 : ICreditorPaymentActivationRequestStatusReportV01
{
    IGroupHeader46 ICreditorPaymentActivationRequestStatusReportV01.GroupHeader => GroupHeader;
    IOriginalGroupInformation25 ICreditorPaymentActivationRequestStatusReportV01.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInformation5? ICreditorPaymentActivationRequestStatusReportV01.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
}
