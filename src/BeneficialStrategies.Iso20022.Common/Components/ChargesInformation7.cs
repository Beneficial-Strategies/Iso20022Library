// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IChargesInformation7"/>
[IsoId("_RtHAHtp-Ed-ak6NoX_4Aeg_-171353542")]
[DisplayName("Charges Information")]
public partial record ChargesInformation7
{
    /// <inheritdoc cref="IChargesInformation7.Amount"/>
    [IsoId("_RtHAH9p-Ed-ak6NoX_4Aeg_-117292823")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="IChargesInformation7.Party"/>
    [IsoId("_RtHAINp-Ed-ak6NoX_4Aeg_911025084")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required BranchAndFinancialInstitutionIdentification5 Party { get; init; }
}
