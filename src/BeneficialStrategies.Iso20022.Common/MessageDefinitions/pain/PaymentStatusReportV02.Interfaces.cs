// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record PaymentStatusReportV02 : IPaymentStatusReportV02
{
    IGroupHeader5 IPaymentStatusReportV02.GroupHeader => GroupHeader;
    IOriginalGroupInformation1 IPaymentStatusReportV02.OriginalGroupInformationAndStatus => OriginalGroupInformationAndStatus;
    IPaymentTransactionInformation1? IPaymentStatusReportV02.TransactionInformationAndStatus => TransactionInformationAndStatus;
}
