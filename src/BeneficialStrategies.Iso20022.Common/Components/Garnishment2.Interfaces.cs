// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Garnishment2 : IGarnishment2
{
    IGarnishmentType1 IGarnishment2.Type => Type;
    IPartyIdentification125? IGarnishment2.Garnishee => Garnishee;
    IPartyIdentification125? IGarnishment2.GarnishmentAdministrator => GarnishmentAdministrator;
}
