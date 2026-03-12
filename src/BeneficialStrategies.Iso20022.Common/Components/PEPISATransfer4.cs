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
[IsoId("_Sg-F-dp-Ed-ak6NoX_4Aeg_30087325")]
[DisplayName("PEPISA Transfer")]
public partial record PEPISATransfer4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_ShHP4Np-Ed-ak6NoX_4Aeg_-1388422279")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Identification of the confirmation assigned by the old plan manager to the transfer of account.
    /// </summary>
    [IsoId("_ShHP4dp-Ed-ak6NoX_4Aeg_31007866")]
    [DisplayName("Transfer Confirmation Identification")]
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationIdentification { get; init; } 
    
    /// <summary>
    /// Identification received by the old plan manager and assigned by the new plan manager to the transfer of account.
    /// </summary>
    [IsoId("_ShHP4tp-Ed-ak6NoX_4Aeg_31007978")]
    [DisplayName("Transfer Instruction Reference")]
    [IsoXmlTag("TrfInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferInstructionReference { get; init; } 
    
    /// <summary>
    /// Date when the transfer instruction was executed.
    /// </summary>
    [IsoId("_ShHP49p-Ed-ak6NoX_4Aeg_31008641")]
    [DisplayName("Actual Transfer Date")]
    [IsoXmlTag("ActlTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ActualTransferDate { get; init; } 
    
    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_ShHP5Np-Ed-ak6NoX_4Aeg_1686210840")]
    [DisplayName("Residual Cash Indicator")]
    [IsoXmlTag("RsdlCshInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ResidualCashIndicator { get; init; } 
    
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. ||The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_ShHP5dp-Ed-ak6NoX_4Aeg_58887035")]
    [DisplayName("ISA")]
    [IsoXmlTag("ISA")]
    public required ISAYearsOfIssue3 ISA { get; init; } 
    
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. ||The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_ShHP5tp-Ed-ak6NoX_4Aeg_138222995")]
    [DisplayName("PEP")]
    [IsoXmlTag("PEP")]
    public required PreviousYearChoice_ PEP { get; init; } 
    
    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [IsoId("_ShHP59p-Ed-ak6NoX_4Aeg_-1561497840")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public required Portfolio1 Portfolio { get; init; } 
    
    /// <summary>
    /// Specifies the underlying assets for the PEP, ISA or portfolio.
    /// </summary>
    [IsoId("_ShHP6Np-Ed-ak6NoX_4Aeg_-1938293075")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument11? FinancialInstrumentAssetForTransfer { get; init; } 
    
    
    #nullable disable
    
}
