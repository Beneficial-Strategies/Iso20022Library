// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Garnishment1 : IGarnishment1
{
    IGarnishmentType1 IGarnishment1.Type => Type;
    IPartyIdentification43? IGarnishment1.Garnishee => Garnishee;
    IPartyIdentification43? IGarnishment1.GarnishmentAdministrator => GarnishmentAdministrator;
}
