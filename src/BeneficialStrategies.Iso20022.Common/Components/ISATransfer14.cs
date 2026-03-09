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
[IsoId("_ueGyoRwpEeOIveEnnb_1-A")]
[DisplayName("ISA Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ISATransfer14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ISATransfer14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ISATransfer14( System.String reqTransferIdentification,System.String reqAllOtherCash )
    {
        TransferIdentification = reqTransferIdentification;
        AllOtherCash = reqAllOtherCash;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_u16OpxwpEeOIveEnnb_1-A")]
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
    /// Identification assigned to the transfer of asset, typically assigned by the transferee.
    /// </summary>
    [IsoId("_u16OqRwpEeOIveEnnb_1-A")]
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
    /// Identification of the confirmation assigned by the transferor to the transfer.
    /// </summary>
    [IsoId("_77eLIBwzEeOIveEnnb_1-A")]
    [DisplayName("Transfer Confirmation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfConfId")]
    #endif
    [IsoXmlTag("TrfConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransferConfirmationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferConfirmationIdentification { get; init; } 
    #else
    public System.String? TransferConfirmationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_u16OqxwpEeOIveEnnb_1-A")]
    [DisplayName("Residual Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsdlCsh")]
    #endif
    [IsoXmlTag("RsdlCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResidualCash1Code? ResidualCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResidualCash1Code? ResidualCash { get; init; } 
    #else
    public ResidualCash1Code? ResidualCash { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    [IsoId("_u16OrRwpEeOIveEnnb_1-A")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISAPortfolio1Choice_? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISAPortfolio1Choice_? Portfolio { get; init; } 
    #else
    public ISAPortfolio1Choice_? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator that all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_u16OrxwpEeOIveEnnb_1-A")]
    [DisplayName("All Other Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllOthrCsh")]
    #endif
    [IsoXmlTag("AllOthrCsh")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AllOtherCash { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AllOtherCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AllOtherCash { get; init; } 
    #else
    public System.String AllOtherCash { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    [IsoId("_u16OsRwpEeOIveEnnb_1-A")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAsstForTrf")]
    #endif
    [IsoXmlTag("FinInstrmAsstForTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument37? FinancialInstrumentAssetForTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument37? FinancialInstrumentAssetForTransfer { get; init; } 
    #else
    public FinancialInstrument37? FinancialInstrumentAssetForTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
