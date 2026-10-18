// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentStatusRequestV02 : IFIToFIPaymentStatusRequestV02
{
    IGroupHeader53 IFIToFIPaymentStatusRequestV02.GroupHeader => GroupHeader;
    IEnumerable<IOriginalGroupInformation27> IFIToFIPaymentStatusRequestV02.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransaction94> IFIToFIPaymentStatusRequestV02.TransactionInformation => TransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentStatusRequestV02.SupplementaryData => SupplementaryData;
}
