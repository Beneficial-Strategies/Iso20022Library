// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV01 : IFIToFIPaymentStatusRequestV01
{
    IGroupHeader53 IFIToFIPaymentStatusRequestV01.GroupHeader => GroupHeader;
    IOriginalGroupInformation27? IFIToFIPaymentStatusRequestV01.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction73? IFIToFIPaymentStatusRequestV01.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentStatusRequestV01.SupplementaryData => SupplementaryData;
}
