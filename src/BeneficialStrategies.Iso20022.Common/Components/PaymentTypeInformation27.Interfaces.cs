// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation27 : IPaymentTypeInformation27
{
    IEnumerable<IServiceLevel8Choice> IPaymentTypeInformation27.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation27.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation27.CategoryPurpose => CategoryPurpose;
}
