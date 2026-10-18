// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV08 : ICustomerPaymentStatusReportV08
{
    IGroupHeader52 ICustomerPaymentStatusReportV08.GroupHeader => GroupHeader;
    IOriginalGroupHeader7 ICustomerPaymentStatusReportV08.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction23? ICustomerPaymentStatusReportV08.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV08.SupplementaryData => SupplementaryData;
}
