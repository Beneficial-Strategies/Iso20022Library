// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CreditorPaymentActivationRequestStatusReportV11 : ICreditorPaymentActivationRequestStatusReportV11
{
    IGroupHeader111 ICreditorPaymentActivationRequestStatusReportV11.GroupHeader => GroupHeader;
    IOriginalGroupInformation32 ICreditorPaymentActivationRequestStatusReportV11.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IOriginalPaymentInstruction47> ICreditorPaymentActivationRequestStatusReportV11.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    IEnumerable<ISupplementaryData1> ICreditorPaymentActivationRequestStatusReportV11.SupplementaryData => SupplementaryData;
}
