// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV04 : IFIToFIPaymentStatusReportV04
{
    IGroupHeader53 IFIToFIPaymentStatusReportV04.GroupHeader => GroupHeader;
    IOriginalGroupHeader1 IFIToFIPaymentStatusReportV04.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IPaymentTransaction33> IFIToFIPaymentStatusReportV04.TransactionInformationAndStatus => TransactionInformationAndStatus;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusReportV04.SupplementaryData => SupplementaryData;
}
