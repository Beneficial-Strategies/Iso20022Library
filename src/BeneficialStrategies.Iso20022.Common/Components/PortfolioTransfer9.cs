// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of product and assets to be transferred.
/// </summary>
[IsoId("_ZS9P4elaEeu9cf4XM82AQQ")]
[DisplayName("Portfolio Transfer")]
public partial record PortfolioTransfer9
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_ZpT6Y-laEeu9cf4XM82AQQ")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_ZpT6ZelaEeu9cf4XM82AQQ")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_ZpT6Z-laEeu9cf4XM82AQQ")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; } 
    
    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_ZpT6aelaEeu9cf4XM82AQQ")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio7Choice_? Portfolio { get; init; } 
    
    /// <summary>
    /// Indicates that not all the assets in the holding/portfolio are specified and that some other kind of other communication is required.
    /// </summary>
    [IsoId("_ZpT6a-laEeu9cf4XM82AQQ")]
    [DisplayName("Partial Discovery")]
    [IsoXmlTag("PrtlDscvry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialDiscovery { get; init; } 
    
    /// <summary>
    /// Specifies whether there is cash in the account awaiting investment and the currency.
    /// </summary>
    [IsoId("_ZpT6belaEeu9cf4XM82AQQ")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1? ResidualCash { get; init; } 
    
    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("_ZpT6b-laEeu9cf4XM82AQQ")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxDate { get; init; } 
    
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_ZpT6celaEeu9cf4XM82AQQ")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument99? FinancialInstrumentAssetForTransfer { get; init; } 
    
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_ZpT6c-laEeu9cf4XM82AQQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
