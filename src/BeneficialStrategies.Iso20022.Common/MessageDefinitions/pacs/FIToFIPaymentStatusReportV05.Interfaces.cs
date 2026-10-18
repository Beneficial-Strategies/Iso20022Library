// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV05 : IFIToFIPaymentStatusReportV05
{
    IGroupHeader53 IFIToFIPaymentStatusReportV05.GroupHeader => GroupHeader;
    IOriginalGroupHeader1 IFIToFIPaymentStatusReportV05.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransaction43? IFIToFIPaymentStatusReportV05.TransactionInformationAndStatus => TransactionInformationAndStatus;
    ISupplementaryData1? IFIToFIPaymentStatusReportV05.SupplementaryData => SupplementaryData;
}
