// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
[IsoId("_R9gMhdp-Ed-ak6NoX_4Aeg_1405165936")]
[DisplayName("Instructed Balance Details")]
public record InstructedBalanceDetails1
{
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_R9gMhtp-Ed-ak6NoX_4Aeg_1822595473")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat1Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_R9gMh9p-Ed-ak6NoX_4Aeg_499849105")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<InstructedCorporateActionOption1> OptionDetails { get; init; } = [];
}
