// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV12 : IFIToFIPaymentStatusReportV12
{
    IGroupHeader101 IFIToFIPaymentStatusReportV12.GroupHeader => GroupHeader;
    IOriginalGroupHeader17? IFIToFIPaymentStatusReportV12.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransaction130? IFIToFIPaymentStatusReportV12.TransactionInformationAndStatus => TransactionInformationAndStatus;
    ISupplementaryData1? IFIToFIPaymentStatusReportV12.SupplementaryData => SupplementaryData;
}
