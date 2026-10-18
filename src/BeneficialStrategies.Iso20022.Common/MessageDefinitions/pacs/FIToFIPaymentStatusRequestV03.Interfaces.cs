// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV03 : IFIToFIPaymentStatusRequestV03
{
    IGroupHeader91 IFIToFIPaymentStatusRequestV03.GroupHeader => GroupHeader;
    IOriginalGroupInformation27? IFIToFIPaymentStatusRequestV03.OriginalGroupInformation => OriginalGroupInformation;
    IPaymentTransaction113? IFIToFIPaymentStatusRequestV03.TransactionInformation => TransactionInformation;
    ISupplementaryData1? IFIToFIPaymentStatusRequestV03.SupplementaryData => SupplementaryData;
}
