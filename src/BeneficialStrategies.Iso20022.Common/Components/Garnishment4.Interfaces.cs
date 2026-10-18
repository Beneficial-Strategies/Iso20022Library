// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Garnishment4 : IGarnishment4
{
    IPartyIdentification272? IGarnishment4.Garnishee => Garnishee;
    IPartyIdentification272? IGarnishment4.GarnishmentAdministrator => GarnishmentAdministrator;
    IGarnishmentType1 IGarnishment4.Type => Type;
}
