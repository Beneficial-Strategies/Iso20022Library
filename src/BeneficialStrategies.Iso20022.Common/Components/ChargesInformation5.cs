// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IChargesInformation5"/>
[IsoId("_Ru5v0Np-Ed-ak6NoX_4Aeg_1858494840")]
[DisplayName("Charges Information")]
public partial record ChargesInformation5
{
    /// <inheritdoc cref="IChargesInformation5.Amount"/>
    [IsoId("_Ru5v0dp-Ed-ak6NoX_4Aeg_1858494842")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="IChargesInformation5.Party"/>
    [IsoId("_Ru5v0tp-Ed-ak6NoX_4Aeg_1858495213")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required BranchAndFinancialInstitutionIdentification4 Party { get; init; }
}
