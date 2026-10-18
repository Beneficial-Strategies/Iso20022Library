// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation26 : IPaymentTypeInformation26
{
    IEnumerable<IServiceLevel8Choice> IPaymentTypeInformation26.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation26.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation26.CategoryPurpose => CategoryPurpose;
}
