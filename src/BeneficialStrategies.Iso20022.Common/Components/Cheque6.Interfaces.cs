// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Cheque6 : ICheque6
{
    INameAndAddress10? ICheque6.ChequeFrom => ChequeFrom;
    IChequeDeliveryMethod1Choice? ICheque6.DeliveryMethod => DeliveryMethod;
    INameAndAddress10? ICheque6.DeliverTo => DeliverTo;
    IEnumerable<string> ICheque6.MemoField => MemoField;
}
