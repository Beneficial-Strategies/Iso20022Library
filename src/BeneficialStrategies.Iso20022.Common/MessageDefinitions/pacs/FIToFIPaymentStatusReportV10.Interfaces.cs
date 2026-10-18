// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV10 : IFIToFIPaymentStatusReportV10
{
    IGroupHeader91 IFIToFIPaymentStatusReportV10.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupHeader17> IFIToFIPaymentStatusReportV10.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IPaymentTransaction110> IFIToFIPaymentStatusReportV10.TransactionInformationAndStatus => TransactionInformationAndStatus;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusReportV10.SupplementaryData => SupplementaryData;
}
