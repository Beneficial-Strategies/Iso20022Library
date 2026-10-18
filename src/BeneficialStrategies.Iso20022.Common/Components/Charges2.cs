// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICharges2"/>
[IsoId("_tjS1UFkyEeGeoaLUQk__nA_-1140480954")]
[DisplayName("Charges")]
public partial record Charges2
{
    /// <inheritdoc cref="ICharges2.Amount"/>
    [IsoId("_tjS1UVkyEeGeoaLUQk__nA_2043574923")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="ICharges2.Agent"/>
    [IsoId("_tjS1UlkyEeGeoaLUQk__nA_428608443")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification5 Agent { get; init; }
}
