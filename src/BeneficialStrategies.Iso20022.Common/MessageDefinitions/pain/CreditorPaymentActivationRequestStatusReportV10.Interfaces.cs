// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV10 : ICreditorPaymentActivationRequestStatusReportV10
{
    IGroupHeader106 ICreditorPaymentActivationRequestStatusReportV10.GroupHeader => GroupHeader;
    IOriginalGroupInformation30 ICreditorPaymentActivationRequestStatusReportV10.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction46? ICreditorPaymentActivationRequestStatusReportV10.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV10.SupplementaryData => SupplementaryData;
}
