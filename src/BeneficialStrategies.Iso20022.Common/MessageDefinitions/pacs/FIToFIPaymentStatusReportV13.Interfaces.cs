// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV13 : IFIToFIPaymentStatusReportV13
{
    IGroupHeader101 IFIToFIPaymentStatusReportV13.GroupHeader => GroupHeader;
    IOriginalGroupHeader17? IFIToFIPaymentStatusReportV13.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransaction142? IFIToFIPaymentStatusReportV13.TransactionInformationAndStatus => TransactionInformationAndStatus;
    ISupplementaryData1? IFIToFIPaymentStatusReportV13.SupplementaryData => SupplementaryData;
}
