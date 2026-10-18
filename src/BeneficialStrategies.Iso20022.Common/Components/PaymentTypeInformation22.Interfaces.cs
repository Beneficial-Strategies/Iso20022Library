// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTypeInformation22 : IPaymentTypeInformation22
{
    IServiceLevel8Choice? IPaymentTypeInformation22.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IPaymentTypeInformation22.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IPaymentTypeInformation22.CategoryPurpose => CategoryPurpose;
}
