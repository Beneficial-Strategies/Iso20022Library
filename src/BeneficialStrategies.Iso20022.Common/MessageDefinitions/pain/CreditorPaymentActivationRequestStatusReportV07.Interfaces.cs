// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV07 : ICreditorPaymentActivationRequestStatusReportV07
{
    IGroupHeader87 ICreditorPaymentActivationRequestStatusReportV07.GroupHeader => GroupHeader;
    IOriginalGroupInformation30 ICreditorPaymentActivationRequestStatusReportV07.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction31? ICreditorPaymentActivationRequestStatusReportV07.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV07.SupplementaryData => SupplementaryData;
}
