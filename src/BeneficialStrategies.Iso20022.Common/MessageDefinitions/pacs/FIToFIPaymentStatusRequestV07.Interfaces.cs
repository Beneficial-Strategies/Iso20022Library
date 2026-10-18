// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV07 : IFIToFIPaymentStatusRequestV07
{
    IGroupHeader109 IFIToFIPaymentStatusRequestV07.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupInformation27> IFIToFIPaymentStatusRequestV07.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusRequestV07.SupplementaryData => SupplementaryData;
    IEnumerable<IPaymentTransaction171> IFIToFIPaymentStatusRequestV07.TransactionInformation => TransactionInformation;
}
