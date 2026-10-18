// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation23 : IPaymentTypeInformation23
{
    IServiceLevel8Choice? IPaymentTypeInformation23.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation23.LocalInstrument => LocalInstrument;
}
