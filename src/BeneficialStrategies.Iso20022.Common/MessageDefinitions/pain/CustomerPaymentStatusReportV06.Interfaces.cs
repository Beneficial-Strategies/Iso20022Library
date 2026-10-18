// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV06 : ICustomerPaymentStatusReportV06
{
    IGroupHeader52 ICustomerPaymentStatusReportV06.GroupHeader => GroupHeader;
    IOriginalGroupHeader1 ICustomerPaymentStatusReportV06.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction12? ICustomerPaymentStatusReportV06.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV06.SupplementaryData => SupplementaryData;
}
