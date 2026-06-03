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
[IsoId("f6b41e2c-7075-4b02-9766-0dddeb9aae33")]
[DisplayName("Portfolio Transfer16")]
public record PortfolioTransfer16
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party.
    /// </summary>
    [IsoId("19c4336c-4e25-47c0-bc78-6c653f6c0bbc")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("e9677538-6619-451a-ad1c-30b332b9e8d6")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("db854119-bcdc-4cfa-b7f5-13b48a996ecb")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; }

    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("5f1bd2e7-ff5f-4c95-99a0-0e79f1c7e227")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio7Choice? Portfolio { get; init; }

    /// <summary>
    /// Indicates that not all the assets in the holding/portfolio are specified and that some other kind of other communication is required.
    /// </summary>
    [IsoId("380593db-5a47-459e-8592-ed1b12880242")]
    [DisplayName("Partial Discovery")]
    [IsoXmlTag("PrtlDscvry")]
    public IsoYesNoIndicator? PartialDiscovery { get; init; }

    /// <summary>
    /// Specifies whether there is cash in the account awaiting investment and the currency.
    /// </summary>
    [IsoId("934edb6f-5eed-4929-88b4-00c8003ca390")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ValueList<ResidualCash1> ResidualCash { get; init; } = [];

    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("297819d9-e6b8-45f9-9fdf-703273017c30")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    public IsoISODate? TaxDate { get; init; }

    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("f22de23a-f875-4f1e-a707-1ca88a6fa263")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public ValueList<FinancialInstrument110> FinancialInstrumentAssetForTransfer { get; init; } = [];

    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("d8cd66b9-15c0-4e60-b9a4-6b66d83d3e8b")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
