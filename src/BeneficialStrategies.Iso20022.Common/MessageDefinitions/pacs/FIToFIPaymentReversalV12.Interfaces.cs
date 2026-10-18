// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV12 : IFIToFIPaymentReversalV12
{
    IGroupHeader97 IFIToFIPaymentReversalV12.GroupHeader => GroupHeader;
    IOriginalGroupHeader16? IFIToFIPaymentReversalV12.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransaction143> IFIToFIPaymentReversalV12.TransactionInformation => TransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentReversalV12.SupplementaryData => SupplementaryData;
}
