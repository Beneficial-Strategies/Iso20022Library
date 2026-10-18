// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV06 : ICreditorPaymentActivationRequestStatusReportV06
{
    IGroupHeader46 ICreditorPaymentActivationRequestStatusReportV06.GroupHeader => GroupHeader;
    IOriginalGroupInformation28 ICreditorPaymentActivationRequestStatusReportV06.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction24? ICreditorPaymentActivationRequestStatusReportV06.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV06.SupplementaryData => SupplementaryData;
}
