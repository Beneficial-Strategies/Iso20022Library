// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV03 : ICreditorPaymentActivationRequestStatusReportV03
{
    IGroupHeader46 ICreditorPaymentActivationRequestStatusReportV03.GroupHeader => GroupHeader;
    IOriginalGroupInformation25 ICreditorPaymentActivationRequestStatusReportV03.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction9? ICreditorPaymentActivationRequestStatusReportV03.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV03.SupplementaryData => SupplementaryData;
}
