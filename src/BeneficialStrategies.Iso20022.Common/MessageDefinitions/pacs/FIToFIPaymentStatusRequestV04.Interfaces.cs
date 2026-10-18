// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV04 : IFIToFIPaymentStatusRequestV04
{
    IGroupHeader91 IFIToFIPaymentStatusRequestV04.GroupHeader => GroupHeader;
    IOriginalGroupInformation27? IFIToFIPaymentStatusRequestV04.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction121? IFIToFIPaymentStatusRequestV04.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentStatusRequestV04.SupplementaryData => SupplementaryData;
}
