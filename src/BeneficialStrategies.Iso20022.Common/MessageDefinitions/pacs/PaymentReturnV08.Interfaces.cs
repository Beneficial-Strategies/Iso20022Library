// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record PaymentReturnV08 : IPaymentReturnV08
{
    IGroupHeader72 IPaymentReturnV08.GroupHeader => GroupHeader;
    IOriginalGroupHeader12? IPaymentReturnV08.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction87? IPaymentReturnV08.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IPaymentReturnV08.SupplementaryData => SupplementaryData;
}
