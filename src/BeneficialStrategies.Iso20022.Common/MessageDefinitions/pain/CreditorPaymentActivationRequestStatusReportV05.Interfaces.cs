// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV05 : ICreditorPaymentActivationRequestStatusReportV05
{
    IGroupHeader46 ICreditorPaymentActivationRequestStatusReportV05.GroupHeader => GroupHeader;
    IOriginalGroupInformation25 ICreditorPaymentActivationRequestStatusReportV05.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction19? ICreditorPaymentActivationRequestStatusReportV05.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV05.SupplementaryData => SupplementaryData;
}
