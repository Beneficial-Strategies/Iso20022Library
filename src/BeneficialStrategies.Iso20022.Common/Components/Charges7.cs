// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICharges7"/>
[IsoId("_-9uzLW49EeiU9cctagi5ow")]
[DisplayName("Charges")]
public partial record Charges7
{
    /// <inheritdoc cref="ICharges7.Amount"/>
    [IsoId("__HkEk249EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="ICharges7.Agent"/>
    [IsoId("__HkElW49EeiU9cctagi5ow")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; }
}
