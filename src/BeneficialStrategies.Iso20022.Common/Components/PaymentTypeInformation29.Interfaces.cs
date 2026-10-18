// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation29 : IPaymentTypeInformation29
{
    IEnumerable<IServiceLevel8Choice> IPaymentTypeInformation29.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation29.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation29.CategoryPurpose => CategoryPurpose;
}
