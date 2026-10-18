// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV06 : IFIToFIPaymentStatusReportV06
{
    IGroupHeader53 IFIToFIPaymentStatusReportV06.GroupHeader => GroupHeader;
    IOriginalGroupHeader1? IFIToFIPaymentStatusReportV06.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransaction52? IFIToFIPaymentStatusReportV06.TransactionInformationAndStatus => TransactionInformationAndStatus;
    ISupplementaryData1? IFIToFIPaymentStatusReportV06.SupplementaryData => SupplementaryData;
}
