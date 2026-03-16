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
[IsoId("_qrHHWc3iEee5nJBZsW8MFQ")]
[DisplayName("Instructed Balance Details")]
public record InstructedBalanceDetails8
{
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_qrHHW83iEee5nJBZsW8MFQ")]
    [DisplayName("Total Instructed Balance")]
    [IsoXmlTag("TtlInstdBal")]
    public required BalanceFormat7Choice_ TotalInstructedBalance { get; init; }

    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_qrHHXc3iEee5nJBZsW8MFQ")]
    [DisplayName("Option Details")]
    [IsoXmlTag("OptnDtls")]
    public ValueList<InstructedCorporateActionOption9> OptionDetails { get; init; } = [];
}
