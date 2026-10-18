// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceAmount3 : IRemittanceAmount3
{
    IEnumerable<IDiscountAmountAndType1> IRemittanceAmount3.DiscountAppliedAmount => DiscountAppliedAmount;
    IEnumerable<ITaxAmountAndType1> IRemittanceAmount3.TaxAmount => TaxAmount;
    IEnumerable<IDocumentAdjustment1> IRemittanceAmount3.AdjustmentAmountAndReason => AdjustmentAmountAndReason;
}
