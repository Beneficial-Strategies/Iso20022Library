// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV05 : ICustomerPaymentStatusReportV05
{
    IGroupHeader52 ICustomerPaymentStatusReportV05.GroupHeader => GroupHeader;
    IOriginalGroupHeader1 ICustomerPaymentStatusReportV05.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction6? ICustomerPaymentStatusReportV05.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV05.SupplementaryData => SupplementaryData;
}
