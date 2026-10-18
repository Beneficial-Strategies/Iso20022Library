// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Cheque7 : ICheque7
{
    INameAndAddress10? ICheque7.ChequeFrom => ChequeFrom;
    IChequeDeliveryMethod1Choice? ICheque7.DeliveryMethod => DeliveryMethod;
    INameAndAddress10? ICheque7.DeliverTo => DeliverTo;
    IEnumerable<string> ICheque7.MemoField => MemoField;
    IEnumerable<string> ICheque7.Signature => Signature;
}
