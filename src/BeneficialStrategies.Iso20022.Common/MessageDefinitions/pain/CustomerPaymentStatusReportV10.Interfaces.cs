// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV10 : ICustomerPaymentStatusReportV10
{
    IGroupHeader86 ICustomerPaymentStatusReportV10.GroupHeader => GroupHeader;
    IOriginalGroupHeader17 ICustomerPaymentStatusReportV10.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction32? ICustomerPaymentStatusReportV10.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV10.SupplementaryData => SupplementaryData;
}
