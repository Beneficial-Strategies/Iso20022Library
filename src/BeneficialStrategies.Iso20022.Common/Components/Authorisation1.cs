// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Autorisation of the mandate holder.
/// </summary>
[IsoId("_PUrJF9p-Ed-ak6NoX_4Aeg_-504716804")]
[DisplayName("Authorisation")]
public record Authorisation1
{
    /// <summary>
    /// Minimum amount per transaction allowed by the mandate.
    /// </summary>
    [IsoId("_PUrJGNp-Ed-ak6NoX_4Aeg_1206246780")]
    [DisplayName("Minimum Amount Per Transaction")]
    [IsoXmlTag("MinAmtPerTx")]
    public required ActiveCurrencyAndAmount MinimumAmountPerTransaction { get; init; }

    /// <summary>
    /// Maximum amount per transaction allowed by the mandate.
    /// </summary>
    [IsoId("_PUrJGdp-Ed-ak6NoX_4Aeg_-151006738")]
    [DisplayName("Maximum Amount Per Transaction")]
    [IsoXmlTag("MaxAmtPerTx")]
    public required ActiveCurrencyAndAmount MaximumAmountPerTransaction { get; init; }

    /// <summary>
    /// Maximum amount allowed over a specific period of time.
    /// </summary>
    [IsoId("_PUrJGtp-Ed-ak6NoX_4Aeg_-1091239434")]
    [DisplayName("Maximum Amount By Period")]
    [IsoXmlTag("MaxAmtByPrd")]
    public MaximumAmountByPeriod1? MaximumAmountByPeriod { get; init; }
}
