// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about a corporate action election.
/// </summary>
[IsoId("_-x7gILbnEe-NMoTZ6Byg6A")]
[DisplayName("Corporate Action Election4")]
public record CorporateActionElection4
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_HAL7A7boEe-NMoTZ6Byg6A")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_HAL7ArboEe-NMoTZ6Byg6A")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption47Choice OptionType { get; init; }

    /// <summary>
    /// Currency in which cash proceeds are to be credited or debited.
    /// </summary>
    [IsoId("_vDl59N7yEe-NrtAAlrBEgQ")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_yvduxN7yEe-NrtAAlrBEgQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice99? PriceDetails { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_btCklLboEe-NMoTZ6Byg6A")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }
}
