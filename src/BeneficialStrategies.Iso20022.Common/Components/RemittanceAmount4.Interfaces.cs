// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceAmount4 : IRemittanceAmount4
{
    IEnumerable<IDocumentAdjustment1> IRemittanceAmount4.AdjustmentAmountAndReason => AdjustmentAmountAndReason;
    IEnumerable<IDocumentAmount1> IRemittanceAmount4.RemittanceAmountAndType => RemittanceAmountAndType;
}
