// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV02 : ICreditorPaymentActivationRequestStatusReportV02
{
    IGroupHeader46 ICreditorPaymentActivationRequestStatusReportV02.GroupHeader => GroupHeader;
    IOriginalGroupInformation25 ICreditorPaymentActivationRequestStatusReportV02.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction5? ICreditorPaymentActivationRequestStatusReportV02.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV02.SupplementaryData => SupplementaryData;
}
