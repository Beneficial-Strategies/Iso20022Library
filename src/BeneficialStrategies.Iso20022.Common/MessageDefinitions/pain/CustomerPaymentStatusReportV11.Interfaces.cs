// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV11 : ICustomerPaymentStatusReportV11
{
    IGroupHeader86 ICustomerPaymentStatusReportV11.GroupHeader => GroupHeader;
    IOriginalGroupHeader17 ICustomerPaymentStatusReportV11.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction38? ICustomerPaymentStatusReportV11.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV11.SupplementaryData => SupplementaryData;
}
