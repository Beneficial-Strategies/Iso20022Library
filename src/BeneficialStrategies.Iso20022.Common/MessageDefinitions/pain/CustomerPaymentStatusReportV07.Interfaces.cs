// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV07 : ICustomerPaymentStatusReportV07
{
    IGroupHeader52 ICustomerPaymentStatusReportV07.GroupHeader => GroupHeader;
    IOriginalGroupHeader1 ICustomerPaymentStatusReportV07.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction18? ICustomerPaymentStatusReportV07.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV07.SupplementaryData => SupplementaryData;
}
