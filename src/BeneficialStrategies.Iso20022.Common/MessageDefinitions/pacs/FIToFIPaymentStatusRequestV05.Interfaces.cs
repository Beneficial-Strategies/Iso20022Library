// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV05 : IFIToFIPaymentStatusRequestV05
{
    IGroupHeader91 IFIToFIPaymentStatusRequestV05.GroupHeader => GroupHeader;
    IOriginalGroupInformation27? IFIToFIPaymentStatusRequestV05.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction131? IFIToFIPaymentStatusRequestV05.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentStatusRequestV05.SupplementaryData => SupplementaryData;
}
