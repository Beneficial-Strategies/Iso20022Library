// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record FIToFIPaymentReversalV11 : IFIToFIPaymentReversalV11
{
    IGroupHeader97 IFIToFIPaymentReversalV11.GroupHeader => GroupHeader;
    IOriginalGroupHeader16? IFIToFIPaymentReversalV11.OriginalGroupInformation => OriginalGroupInformation;
    IEnumerable<IPaymentTransaction135> IFIToFIPaymentReversalV11.TransactionInformation => TransactionInformation;
    IEnumerable<ISupplementaryData1> IFIToFIPaymentReversalV11.SupplementaryData => SupplementaryData;
}
