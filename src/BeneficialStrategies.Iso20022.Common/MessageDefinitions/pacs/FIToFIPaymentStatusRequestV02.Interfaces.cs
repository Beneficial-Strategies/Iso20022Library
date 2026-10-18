// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV02 : IFIToFIPaymentStatusRequestV02
{
    IGroupHeader53 IFIToFIPaymentStatusRequestV02.GroupHeader => GroupHeader;
    IOriginalGroupInformation27? IFIToFIPaymentStatusRequestV02.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction94? IFIToFIPaymentStatusRequestV02.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentStatusRequestV02.SupplementaryData => SupplementaryData;
}
