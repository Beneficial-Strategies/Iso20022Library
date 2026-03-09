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
/// Type of product and assets to be transferred.
/// </summary>
[IsoId("_4WHGsU4DEeiQHa-q1Uephw")]
[DisplayName("Portfolio Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PortfolioTransfer1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PortfolioTransfer1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PortfolioTransfer1( System.String reqTransferIdentification )
    {
        TransferIdentification = reqTransferIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_4nhm004DEeiQHa-q1Uephw")]
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
    /// Identification assigned to the transfer of assets.
    /// </summary>
    [IsoId("_4nhm1U4DEeiQHa-q1Uephw")]
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
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_4nhm104DEeiQHa-q1Uephw")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundPortfolio1Choice_? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundPortfolio1Choice_? Portfolio { get; init; } 
    #else
    public FundPortfolio1Choice_? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash. 
    /// </summary>
    [IsoId("_4nhm2U4DEeiQHa-q1Uephw")]
    [DisplayName("All Other Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllOthrCsh")]
    #endif
    [IsoXmlTag("AllOthrCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AllOtherCash1Code? AllOtherCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AllOtherCash1Code? AllOtherCash { get; init; } 
    #else
    public AllOtherCash1Code? AllOtherCash { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether all assets in the portfolio should be liquidated and transferred as cash.
    /// </summary>
    [IsoId("_iPuUIM4EEeiAhd-njDxLnA")]
    [DisplayName("Cash All")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAll")]
    #endif
    [IsoXmlTag("CshAll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAll1Code? CashAll { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAll1Code? CashAll { get; init; } 
    #else
    public CashAll1Code? CashAll { get; set; } 
    #endif
    
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_4nhm204DEeiQHa-q1Uephw")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAsstForTrf")]
    #endif
    [IsoXmlTag("FinInstrmAsstForTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument67? FinancialInstrumentAssetForTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument67? FinancialInstrumentAssetForTransfer { get; init; } 
    #else
    public FinancialInstrument67? FinancialInstrumentAssetForTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_M9lCQJClEeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
