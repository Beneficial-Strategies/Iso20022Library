// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusReportV03 : IFIToFIPaymentStatusReportV03
{
    IGroupHeader37 IFIToFIPaymentStatusReportV03.GroupHeader => GroupHeader;
    IOriginalGroupInformation20 IFIToFIPaymentStatusReportV03.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransactionInformation26? IFIToFIPaymentStatusReportV03.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
