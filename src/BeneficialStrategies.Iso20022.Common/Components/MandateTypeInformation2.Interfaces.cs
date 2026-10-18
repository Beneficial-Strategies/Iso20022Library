// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record MandateTypeInformation2 : IMandateTypeInformation2
{
    IServiceLevel8Choice? IMandateTypeInformation2.ServiceLevel => ServiceLevel;
    ILocalInstrument2Choice? IMandateTypeInformation2.LocalInstrument => LocalInstrument;
    ICategoryPurpose1Choice? IMandateTypeInformation2.CategoryPurpose => CategoryPurpose;
    IMandateClassification1Choice? IMandateTypeInformation2.Classification => Classification;
}
