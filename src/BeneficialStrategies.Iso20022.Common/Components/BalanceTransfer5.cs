// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance Transfer5.
/// </summary>
[IsoId("_8NntVTEsEe6GxLzpkVnWYg")]
[DisplayName("Balance Transfer5")]
public record BalanceTransfer5
{
    /// <summary>
    /// Balance Transfer Funding Limit.
    /// </summary>
    [DisplayName("Balance Transfer Funding Limit")]
    [IsoXmlTag("BalTrfFndgLmt")]
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; }

    /// <summary>
    /// Balance Transfer Method.
    /// </summary>
    [DisplayName("Balance Transfer Method")]
    [IsoXmlTag("BalTrfMtd")]
    public SettlementMethod5Choice_? BalanceTransferMethod { get; init; }

    /// <summary>
    /// Balance Transfer Reference.
    /// </summary>
    [DisplayName("Balance Transfer Reference")]
    [IsoXmlTag("BalTrfRef")]
    public BalanceTransferReference1? BalanceTransferReference { get; init; }
}
