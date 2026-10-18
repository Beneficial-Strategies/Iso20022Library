// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV09 : ICreditorPaymentActivationRequestStatusReportV09
{
    IGroupHeader87 ICreditorPaymentActivationRequestStatusReportV09.GroupHeader => GroupHeader;
    IOriginalGroupInformation30 ICreditorPaymentActivationRequestStatusReportV09.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction42? ICreditorPaymentActivationRequestStatusReportV09.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICreditorPaymentActivationRequestStatusReportV09.SupplementaryData => SupplementaryData;
}
