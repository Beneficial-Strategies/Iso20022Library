// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV07 : IFIToFIPaymentStatusReportV07
{
    IGroupHeader53 IFIToFIPaymentStatusReportV07.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupHeader1> IFIToFIPaymentStatusReportV07.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IEnumerable<IPaymentTransaction63> IFIToFIPaymentStatusReportV07.TransactionInformationAndStatus => TransactionInformationAndStatus;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusReportV07.SupplementaryData => SupplementaryData;
}
