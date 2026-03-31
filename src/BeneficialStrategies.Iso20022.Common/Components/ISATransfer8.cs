// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("_M4xaERgHEeKqWJINzXcn5g")]
[DisplayName("ISA Transfer")]
public record ISATransfer8
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_NNyn0RgHEeKqWJINzXcn5g")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    [IsoId("_NNyn1RgHEeKqWJINzXcn5g")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_NNyn2RgHEeKqWJINzXcn5g")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_NNyn3RgHEeKqWJINzXcn5g")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1Code? ResidualCash { get; init; }

    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    [IsoId("_NNyn4RgHEeKqWJINzXcn5g")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public required ISAPortfolio1Choice_ Portfolio { get; init; }

    /// <summary>
    /// Indicator that all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_NNyn5RgHEeKqWJINzXcn5g")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AllOtherCash { get; init; }

    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    [IsoId("_NNyn6RgHEeKqWJINzXcn5g")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument32> FinancialInstrumentAssetForTransfer { get; init; } = [];
}
