// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of product and assets to be transferred.
/// </summary>
[IsoId("_Fzt8A4fuEeevKP8c-ilVhA")]
[DisplayName("ISA Transfer")]
public record ISATransfer31
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_GEYOI4fuEeevKP8c-ilVhA")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_GEYOJYfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    [IsoId("_GEYOJ4fuEeevKP8c-ilVhA")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public ISAPortfolio4Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_GEYOKYfuEeevKP8c-ilVhA")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1Code? AllOtherCash { get; init; }

    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    [IsoId("_GEYOK4fuEeevKP8c-ilVhA")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument64> FinancialInstrumentAssetForTransfer { get; init; } = [];
}
