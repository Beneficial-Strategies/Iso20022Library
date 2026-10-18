// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV09 : IFIToFIPaymentStatusReportV09
{
    IGroupHeader53 IFIToFIPaymentStatusReportV09.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupHeader13> IFIToFIPaymentStatusReportV09.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IPaymentTransaction91> IFIToFIPaymentStatusReportV09.TransactionInformationAndStatus => TransactionInformationAndStatus;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusReportV09.SupplementaryData => SupplementaryData;
}
