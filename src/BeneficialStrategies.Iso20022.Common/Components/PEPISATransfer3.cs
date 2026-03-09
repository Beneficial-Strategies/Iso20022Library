// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("_ShRA49p-Ed-ak6NoX_4Aeg_783524174")]
[DisplayName("PEPISA Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PEPISATransfer3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PEPISATransfer3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PEPISATransfer3( System.String reqTransferIdentification,System.String reqResidualCashIndicator,ISAYearsOfIssue1 reqISA,PreviousYearChoice_ reqPEP,Portfolio1 reqPortfolio )
    {
        TransferIdentification = reqTransferIdentification;
        ResidualCashIndicator = reqResidualCashIndicator;
        ISA = reqISA;
        PEP = reqPEP;
        Portfolio = reqPortfolio;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_ShRA5Np-Ed-ak6NoX_4Aeg_-1650699919")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    [IsoId("_ShRA5dp-Ed-ak6NoX_4Aeg_784444259")]
    [DisplayName("Transfer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfId")]
    #endif
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferIdentification { get; init; } 
    #else
    public System.String TransferIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_ShRA5tp-Ed-ak6NoX_4Aeg_153165977")]
    [DisplayName("Residual Cash Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsdlCshInd")]
    #endif
    [IsoXmlTag("RsdlCshInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ResidualCashIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ResidualCashIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResidualCashIndicator { get; init; } 
    #else
    public System.String ResidualCashIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. |The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_ShRA59p-Ed-ak6NoX_4Aeg_784444457")]
    [DisplayName("ISA")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISA")]
    #endif
    [IsoXmlTag("ISA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISAYearsOfIssue1 ISA { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ISAYearsOfIssue1 ISA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISAYearsOfIssue1 ISA { get; init; } 
    #else
    public ISAYearsOfIssue1 ISA { get; set; } 
    #endif
    
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. ||The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_ShRA6Np-Ed-ak6NoX_4Aeg_-56499849")]
    [DisplayName("PEP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PEP")]
    #endif
    [IsoXmlTag("PEP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PreviousYearChoice_ PEP { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PreviousYearChoice_ PEP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYearChoice_ PEP { get; init; } 
    #else
    public PreviousYearChoice_ PEP { get; set; } 
    #endif
    
    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [IsoId("_ShRA6dp-Ed-ak6NoX_4Aeg_580203747")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Portfolio1 Portfolio { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Portfolio1 Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Portfolio1 Portfolio { get; init; } 
    #else
    public Portfolio1 Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying assets for the PEP, ISA or portfolio.
    /// </summary>
    [IsoId("_ShRA6tp-Ed-ak6NoX_4Aeg_1357950719")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAsstForTrf")]
    #endif
    [IsoXmlTag("FinInstrmAsstForTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument11? FinancialInstrumentAssetForTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument11? FinancialInstrumentAssetForTransfer { get; init; } 
    #else
    public FinancialInstrument11? FinancialInstrumentAssetForTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
