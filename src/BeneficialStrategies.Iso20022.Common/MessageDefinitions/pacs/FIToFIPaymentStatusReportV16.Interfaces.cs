// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV16 : IFIToFIPaymentStatusReportV16
{
    IGroupHeader120 IFIToFIPaymentStatusReportV16.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupHeader22> IFIToFIPaymentStatusReportV16.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IPaymentTransaction177> IFIToFIPaymentStatusReportV16.TransactionInformationAndStatus => TransactionInformationAndStatus;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusReportV16.SupplementaryData => SupplementaryData;
}
