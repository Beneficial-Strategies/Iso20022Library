// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation21 : IPaymentTypeInformation21
{
    IServiceLevel8Choice? IPaymentTypeInformation21.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation21.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation21.CategoryPurpose => CategoryPurpose;
}
