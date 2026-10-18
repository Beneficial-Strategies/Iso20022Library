// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation4 : IPaymentTypeInformation4
{
    IServiceLevel3Choice? IPaymentTypeInformation4.ServiceLevel => ServiceLevel;
    ILocalInstrument1Choice? IPaymentTypeInformation4.LocalInstrument => LocalInstrument;
}
