// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV04 : ICustomerPaymentStatusReportV04
{
    IGroupHeader52 ICustomerPaymentStatusReportV04.GroupHeader => GroupHeader;
    IOriginalGroupHeader1 ICustomerPaymentStatusReportV04.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction1? ICustomerPaymentStatusReportV04.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV04.SupplementaryData => SupplementaryData;
}
