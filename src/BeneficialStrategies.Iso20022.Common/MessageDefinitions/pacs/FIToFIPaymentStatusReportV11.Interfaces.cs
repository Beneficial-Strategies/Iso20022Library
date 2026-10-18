// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV11 : IFIToFIPaymentStatusReportV11
{
    IGroupHeader91 IFIToFIPaymentStatusReportV11.GroupHeader => GroupHeader;
    IOriginalGroupHeader17? IFIToFIPaymentStatusReportV11.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransaction123? IFIToFIPaymentStatusReportV11.TransactionInformationAndStatus => TransactionInformationAndStatus;
    ISupplementaryData1? IFIToFIPaymentStatusReportV11.SupplementaryData => SupplementaryData;
}
