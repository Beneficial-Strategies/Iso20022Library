// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV15 : IFIToFIPaymentStatusReportV15
{
    IGroupHeader120 IFIToFIPaymentStatusReportV15.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupHeader22> IFIToFIPaymentStatusReportV15.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IPaymentTransaction164> IFIToFIPaymentStatusReportV15.TransactionInformationAndStatus => TransactionInformationAndStatus;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusReportV15.SupplementaryData => SupplementaryData;
}
