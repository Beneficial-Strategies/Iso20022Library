// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV12 : ICreditorPaymentActivationRequestStatusReportV12
{
    IGroupHeader111 ICreditorPaymentActivationRequestStatusReportV12.GroupHeader => GroupHeader;
    IOriginalGroupInformation32 ICreditorPaymentActivationRequestStatusReportV12.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IOriginalPaymentInstruction52> ICreditorPaymentActivationRequestStatusReportV12.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    IEnumerable<ISupplementaryData1> ICreditorPaymentActivationRequestStatusReportV12.SupplementaryData => SupplementaryData;
}
