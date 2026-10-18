// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV08 : IFIToFIPaymentStatusReportV08
{
    IGroupHeader53 IFIToFIPaymentStatusReportV08.GroupHeader => GroupHeader;
    IOriginalGroupHeader7? IFIToFIPaymentStatusReportV08.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransaction80? IFIToFIPaymentStatusReportV08.TransactionInformationAndStatus => TransactionInformationAndStatus;
    ISupplementaryData1? IFIToFIPaymentStatusReportV08.SupplementaryData => SupplementaryData;
}
