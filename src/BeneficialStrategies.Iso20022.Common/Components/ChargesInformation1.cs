// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IChargesInformation1"/>
[IsoId("_RtjsAtp-Ed-ak6NoX_4Aeg_-450206740")]
[DisplayName("Charges Information")]
public partial record ChargesInformation1
{
    /// <inheritdoc cref="IChargesInformation1.ChargesAmount"/>
    [IsoId("_RtjsA9p-Ed-ak6NoX_4Aeg_1765318183")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public required CurrencyAndAmount ChargesAmount { get; init; }

    /// <inheritdoc cref="IChargesInformation1.ChargesParty"/>
    [IsoId("_RtjsBNp-Ed-ak6NoX_4Aeg_1407518272")]
    [DisplayName("Charges Party")]
    [IsoXmlTag("ChrgsPty")]
    public required BranchAndFinancialInstitutionIdentification3 ChargesParty { get; init; }
}
