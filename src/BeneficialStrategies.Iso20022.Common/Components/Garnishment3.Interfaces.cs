// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Garnishment3 : IGarnishment3
{
    IGarnishmentType1 IGarnishment3.Type => Type;
    IPartyIdentification135? IGarnishment3.Garnishee => Garnishee;
    IPartyIdentification135? IGarnishment3.GarnishmentAdministrator => GarnishmentAdministrator;
}
