// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV13 : ICustomerPaymentStatusReportV13
{
    IGroupHeader86 ICustomerPaymentStatusReportV13.GroupHeader => GroupHeader;
    IOriginalGroupHeader17 ICustomerPaymentStatusReportV13.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction45? ICustomerPaymentStatusReportV13.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV13.SupplementaryData => SupplementaryData;
}
