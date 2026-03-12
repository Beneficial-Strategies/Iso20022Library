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
[IsoId("_YUPyz-lfEeu9cf4XM82AQQ")]
[DisplayName("Portfolio Transfer")]
public partial record PortfolioTransfer10
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Yq5YE-lfEeu9cf4XM82AQQ")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_Yq5YFelfEeu9cf4XM82AQQ")]
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferInstructionReference { get; init; } 
    
    /// <summary>
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_Yq5YF-lfEeu9cf4XM82AQQ")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationIdentification { get; init; } 
    
    /// <summary>
    /// Date the portfolio transfer instruction was executed.
    /// </summary>
    [IsoId("_Yq5YGelfEeu9cf4XM82AQQ")]
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ActualTransferDate { get; init; } 
    
    /// <summary>
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_Yq5YG-lfEeu9cf4XM82AQQ")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public FundPortfolio7Choice_? Portfolio { get; init; } 
    
    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_Yq5YHelfEeu9cf4XM82AQQ")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    public AllOtherCash1? AllOtherCash { get; init; } 
    
    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_Yq5YH-lfEeu9cf4XM82AQQ")]
    [DisplayName("Cash All")]
    [IsoXmlTag("CshAll")]
    public CashAll1? CashAll { get; init; } 
    
    /// <summary>
    /// Specifies how the cash in the account that is awaiting investment is to be dealt with
    /// </summary>
    [IsoId("_Yq5YIelfEeu9cf4XM82AQQ")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash2? ResidualCash { get; init; } 
    
    /// <summary>
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("_Yq5YI-lfEeu9cf4XM82AQQ")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxDate { get; init; } 
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_Yq5YJelfEeu9cf4XM82AQQ")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument14? PaymentDetails { get; init; } 
    
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_Yq5YJ-lfEeu9cf4XM82AQQ")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument100? FinancialInstrumentAssetForTransfer { get; init; } 
    
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_Yq5YKelfEeu9cf4XM82AQQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
