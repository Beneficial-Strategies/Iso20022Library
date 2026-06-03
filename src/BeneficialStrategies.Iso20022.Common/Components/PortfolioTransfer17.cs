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
[IsoId("9676948d-16b6-453e-91ef-6928b2f4c105")]
[DisplayName("Portfolio Transfer17")]
public record PortfolioTransfer17
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party.
    /// </summary>
    [IsoId("78dd4dea-2ecb-4bc3-8bef-2f33f89e9e47")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("c2c1c16f-07a2-40ba-beee-49640a370e05")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("2807b0a3-e53f-418c-b665-fe873970d1ad")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio9Choice? Portfolio { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("780c7116-11bd-475b-a601-5575573b4520")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument111> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("4176e39f-25cf-47c1-8630-4df70fe70b56")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
