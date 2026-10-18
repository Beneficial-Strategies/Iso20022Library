// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Cheque16 : ICheque16
{
    INameAndAddress16? ICheque16.ChequeFrom => ChequeFrom;
    IChequeDeliveryMethod1Choice? ICheque16.DeliveryMethod => DeliveryMethod;
    INameAndAddress16? ICheque16.DeliverTo => DeliverTo;
    IEnumerable<string> ICheque16.MemoField => MemoField;
    IEnumerable<string> ICheque16.Signature => Signature;
}
