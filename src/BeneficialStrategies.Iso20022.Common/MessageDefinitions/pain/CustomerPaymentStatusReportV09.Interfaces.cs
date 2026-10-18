// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV09 : ICustomerPaymentStatusReportV09
{
    IGroupHeader74 ICustomerPaymentStatusReportV09.GroupHeader => GroupHeader;
    IOriginalGroupHeader13 ICustomerPaymentStatusReportV09.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IOriginalPaymentInstruction27? ICustomerPaymentStatusReportV09.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    ISupplementaryData1? ICustomerPaymentStatusReportV09.SupplementaryData => SupplementaryData;
}
