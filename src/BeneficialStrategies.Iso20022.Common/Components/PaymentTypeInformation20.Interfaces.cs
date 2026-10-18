// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation20 : IPaymentTypeInformation20
{
    IServiceLevel8Choice? IPaymentTypeInformation20.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation20.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation20.CategoryPurpose => CategoryPurpose;
}
