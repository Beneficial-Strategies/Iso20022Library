// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV04 : ICreditorPaymentActivationRequestStatusReportV04
{
    IGroupHeader46 ICreditorPaymentActivationRequestStatusReportV04.GroupHeader => GroupHeader;
    IOriginalGroupInformation25 ICreditorPaymentActivationRequestStatusReportV04.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction14? ICreditorPaymentActivationRequestStatusReportV04.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV04.SupplementaryData => SupplementaryData;
}
