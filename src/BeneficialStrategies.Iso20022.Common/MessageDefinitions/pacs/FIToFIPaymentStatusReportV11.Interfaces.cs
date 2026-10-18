// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV11 : IFIToFIPaymentStatusReportV11
{
    IGroupHeader91 IFIToFIPaymentStatusReportV11.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupHeader17> IFIToFIPaymentStatusReportV11.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IPaymentTransaction123> IFIToFIPaymentStatusReportV11.TransactionInformationAndStatus => TransactionInformationAndStatus;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusReportV11.SupplementaryData => SupplementaryData;
}
