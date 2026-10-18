// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation24 : IPaymentTypeInformation24
{
    IServiceLevel8Choice? IPaymentTypeInformation24.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation24.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation24.CategoryPurpose => CategoryPurpose;
}
