// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV06 : IFIToFIPaymentStatusRequestV06
{
    IGroupHeader109 IFIToFIPaymentStatusRequestV06.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupInformation27> IFIToFIPaymentStatusRequestV06.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusRequestV06.SupplementaryData => SupplementaryData;
    IEnumerable<IPaymentTransaction158> IFIToFIPaymentStatusRequestV06.TransactionInformation => TransactionInformation;
}
