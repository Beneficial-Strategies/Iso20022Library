// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV01 : IFIToFIPaymentStatusRequestV01
{
    IGroupHeader53 IFIToFIPaymentStatusRequestV01.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupInformation27> IFIToFIPaymentStatusRequestV01.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransaction73> IFIToFIPaymentStatusRequestV01.TransactionInformation => TransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusRequestV01.SupplementaryData => SupplementaryData;
}
