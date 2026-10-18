// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICharges12"/>
[IsoId("_NfldERlWEe2Do_UtrNmb2g")]
[DisplayName("Charges")]
public partial record Charges12
{
    /// <inheritdoc cref="ICharges12.Amount"/>
    [IsoId("_NqTfUxlWEe2Do_UtrNmb2g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="ICharges12.Agent"/>
    [IsoId("_NqTfVRlWEe2Do_UtrNmb2g")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; }

    /// <inheritdoc cref="ICharges12.Type"/>
    [IsoId("_W6o64BlZEe2Do_UtrNmb2g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; }
}
