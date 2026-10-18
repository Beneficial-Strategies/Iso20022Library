// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation1 : IPaymentTypeInformation1
{
    IServiceLevel2Choice? IPaymentTypeInformation1.ServiceLevel => ServiceLevel;
    ILocalInstrument1Choice? IPaymentTypeInformation1.LocalInstrument => LocalInstrument;
}
