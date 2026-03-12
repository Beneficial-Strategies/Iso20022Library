// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("_bpWdARgIEeKqWJINzXcn5g")]
[DisplayName("ISA Transfer")]
public partial record ISATransfer10
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_b-g0vRgIEeKqWJINzXcn5g")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Identification of the confirmation assigned by the old plan manager to the transfer of account.
    /// </summary>
    [IsoId("_b-g0wRgIEeKqWJINzXcn5g")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationIdentification { get; init; } 
    
    /// <summary>
    /// Identification received by the old plan manager and assigned by the new plan manager to the transfer of account.
    /// </summary>
    [IsoId("_b-g0xRgIEeKqWJINzXcn5g")]
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferInstructionReference { get; init; } 
    
    /// <summary>
    /// Date when the transfer instruction was executed.
    /// </summary>
    [IsoId("_b-g0yRgIEeKqWJINzXcn5g")]
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ActualTransferDate { get; init; } 
    
    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_b-g0zRgIEeKqWJINzXcn5g")]
    [DisplayName("Residual Cash")]
    [IsoXmlTag("RsdlCsh")]
    public ResidualCash1Code? ResidualCash { get; init; } 
    
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    [IsoId("_b-g00RgIEeKqWJINzXcn5g")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public required ISAPortfolio2Choice_ Portfolio { get; init; } 
    
    /// <summary>
    /// Indicator that all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_b-g01RgIEeKqWJINzXcn5g")]
    [DisplayName("All Other Cash")]
    [IsoXmlTag("AllOthrCsh")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AllOtherCash { get; init; } 
    
    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    [IsoId("_b-g02RgIEeKqWJINzXcn5g")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument33? FinancialInstrumentAssetForTransfer { get; init; } 
    
    
    #nullable disable
    
}
