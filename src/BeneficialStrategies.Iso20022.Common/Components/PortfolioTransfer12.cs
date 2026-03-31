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
[IsoId("_YsEbzelqEeuvhrZwLF0fDg")]
[DisplayName("Portfolio Transfer")]
public record PortfolioTransfer12
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_ZCbGQ-lqEeuvhrZwLF0fDg")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_ZCbGRelqEeuvhrZwLF0fDg")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_ZCbGR-lqEeuvhrZwLF0fDg")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio9Choice_? Portfolio { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_ZCbGSelqEeuvhrZwLF0fDg")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument101> FinancialInstrumentAssetForTransfer { get; init; } =
        [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_ZCbGS-lqEeuvhrZwLF0fDg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
