// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation2 : IPaymentTypeInformation2
{
    IServiceLevel3Choice? IPaymentTypeInformation2.ServiceLevel => ServiceLevel;
    ILocalInstrument1Choice? IPaymentTypeInformation2.LocalInstrument => LocalInstrument;
}
