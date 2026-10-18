// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceAmount2 : IRemittanceAmount2
{
    IEnumerable<IDiscountAmountAndType1> IRemittanceAmount2.DiscountAppliedAmount => DiscountAppliedAmount;
    IEnumerable<ITaxAmountAndType1> IRemittanceAmount2.TaxAmount => TaxAmount;
    IEnumerable<IDocumentAdjustment1> IRemittanceAmount2.AdjustmentAmountAndReason => AdjustmentAmountAndReason;
}
