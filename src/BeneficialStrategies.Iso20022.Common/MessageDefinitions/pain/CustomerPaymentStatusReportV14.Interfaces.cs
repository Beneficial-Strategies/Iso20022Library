// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record CustomerPaymentStatusReportV14 : ICustomerPaymentStatusReportV14
{
    IGroupHeader128 ICustomerPaymentStatusReportV14.GroupHeader => GroupHeader;
    IOriginalGroupHeader22 ICustomerPaymentStatusReportV14.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IOriginalPaymentInstruction51> ICustomerPaymentStatusReportV14.OriginalPaymentInformationAndStatus => OriginalPaymentInformationAndStatus;
    IEnumerable<ISupplementaryData1> ICustomerPaymentStatusReportV14.SupplementaryData => SupplementaryData;
}
