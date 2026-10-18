// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Cheque19 : ICheque19
{
    INameAndAddress18? ICheque19.ChequeFrom => ChequeFrom;
    INameAndAddress18? ICheque19.DeliverTo => DeliverTo;
    IChequeDeliveryMethod1Choice? ICheque19.DeliveryMethod => DeliveryMethod;
    IEnumerable<IsoMax35Text> ICheque19.MemoField => MemoField;
    IEnumerable<IsoMax70Text> ICheque19.Signature => Signature;
}
