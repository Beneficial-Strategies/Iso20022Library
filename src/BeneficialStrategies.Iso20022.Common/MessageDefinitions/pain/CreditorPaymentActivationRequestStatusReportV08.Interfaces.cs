// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV08 : ICreditorPaymentActivationRequestStatusReportV08
{
    IGroupHeader87 ICreditorPaymentActivationRequestStatusReportV08.GroupHeader => GroupHeader;
    IOriginalGroupInformation30 ICreditorPaymentActivationRequestStatusReportV08.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction39? ICreditorPaymentActivationRequestStatusReportV08.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV08.SupplementaryData => SupplementaryData;
}
