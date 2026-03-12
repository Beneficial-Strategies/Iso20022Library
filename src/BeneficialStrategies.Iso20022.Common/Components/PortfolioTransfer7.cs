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
[IsoId("_nScMI5NBEemQB_8XA98K0Q")]
[DisplayName("Portfolio Transfer")]
public partial record PortfolioTransfer7
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_npD8U5NBEemQB_8XA98K0Q")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_npD8VZNBEemQB_8XA98K0Q")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_npD8V5NBEemQB_8XA98K0Q")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationIdentification { get; init; } 
    
    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_npD8WZNBEemQB_8XA98K0Q")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio5Choice_? Portfolio { get; init; } 
    
    /// <summary>
    /// Indicates that not all the assets in the holding/portfolio are specified and that some other kind of other communication is required.
    /// </summary>
    [IsoId("_0VfaUJP_EemyZbjY08A1Vw")]
    [DisplayName("Partial Discovery")]
    [IsoXmlTag("PrtlDscvry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialDiscovery { get; init; } 
    
    /// <summary>
    /// Specifies whether there is cash in the account awaiting investment and the currency.
    /// </summary>
    [IsoId("_npD8X5NBEemQB_8XA98K0Q")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1? ResidualCash { get; init; } 
    
    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("_npD8YZNBEemQB_8XA98K0Q")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxDate { get; init; } 
    
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_npD8Y5NBEemQB_8XA98K0Q")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument85? FinancialInstrumentAssetForTransfer { get; init; } 
    
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_npD8ZZNBEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
