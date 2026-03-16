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
[IsoId("_4WHGsU4DEeiQHa-q1Uephw")]
[DisplayName("Portfolio Transfer")]
public record PortfolioTransfer1
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_4nhm004DEeiQHa-q1Uephw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_4nhm1U4DEeiQHa-q1Uephw")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_4nhm104DEeiQHa-q1Uephw")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio1Choice_? Portfolio { get; init; }

    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_4nhm2U4DEeiQHa-q1Uephw")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1Code? AllOtherCash { get; init; }

    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_iPuUIM4EEeiAhd-njDxLnA")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public CashAll1Code? CashAll { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_4nhm204DEeiQHa-q1Uephw")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument67? FinancialInstrumentAssetForTransfer { get; init; }

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_M9lCQJClEeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
