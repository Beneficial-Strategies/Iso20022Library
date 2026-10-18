// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Cheque5 : ICheque5
{
    INameAndAddress3? ICheque5.ChequeFrom => ChequeFrom;
    IChequeDeliveryMethod1Choice? ICheque5.DeliveryMethod => DeliveryMethod;
    INameAndAddress3? ICheque5.DeliverTo => DeliverTo;
}
