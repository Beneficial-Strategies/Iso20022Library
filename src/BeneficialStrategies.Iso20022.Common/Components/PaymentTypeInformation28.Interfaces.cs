// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation28 : IPaymentTypeInformation28
{
    IEnumerable<IServiceLevel8Choice> IPaymentTypeInformation28.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation28.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation28.CategoryPurpose => CategoryPurpose;
}
