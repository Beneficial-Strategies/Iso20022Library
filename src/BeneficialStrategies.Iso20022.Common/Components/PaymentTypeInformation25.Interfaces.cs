// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation25 : IPaymentTypeInformation25
{
    IServiceLevel8Choice? IPaymentTypeInformation25.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation25.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation25.CategoryPurpose => CategoryPurpose;
}
