// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation19 : IPaymentTypeInformation19
{
    IServiceLevel8Choice? IPaymentTypeInformation19.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation19.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation19.CategoryPurpose => CategoryPurpose;
}
