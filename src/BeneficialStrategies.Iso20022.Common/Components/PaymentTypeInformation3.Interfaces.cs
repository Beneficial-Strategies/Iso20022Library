// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation3 : IPaymentTypeInformation3
{
    IServiceLevel2Choice? IPaymentTypeInformation3.ServiceLevel => ServiceLevel;
    ILocalInstrument1Choice? IPaymentTypeInformation3.LocalInstrument => LocalInstrument;
}
