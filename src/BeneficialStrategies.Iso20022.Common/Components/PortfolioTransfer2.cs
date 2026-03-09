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
[IsoId("_PWwCsU4CEeiQHa-q1Uephw")]
[DisplayName("Portfolio Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PortfolioTransfer2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PortfolioTransfer2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PortfolioTransfer2( System.String reqTransferIdentification )
    {
        TransferIdentification = reqTransferIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Pm9o804CEeiQHa-q1Uephw")]
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
    [IsoId("_Pm9o9U4CEeiQHa-q1Uephw")]
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
    [IsoId("_Pm9o904CEeiQHa-q1Uephw")]
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
    /// Choice of tax efficient product, general investment or pension.
    /// </summary>
    [IsoId("_Pm9o-04CEeiQHa-q1Uephw")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundPortfolio2Choice_? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundPortfolio2Choice_? Portfolio { get; init; } 
    #else
    public FundPortfolio2Choice_? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether all remaining assets in the portfolio not listed for transfer should be liquidated and transferred as cash. 
    /// </summary>
    [IsoId("_Pm9o_U4CEeiQHa-q1Uephw")]
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
    [IsoId("_cjs6kc4GEeiAhd-njDxLnA")]
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
    /// Specifies what must be done with cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_Pm9o-U4CEeiQHa-q1Uephw")]
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
    /// Tax date applicable to all the assets.
    /// </summary>
    [IsoId("_ZZeaUaFQEei_VZq-6SQkuQ")]
    [DisplayName("Tax Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDt")]
    #endif
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TaxDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TaxDate { get; init; } 
    #else
    public System.DateOnly? TaxDate { get; set; } 
    #endif
    
    /// <summary>
    /// Asset to be transferred.
    /// </summary>
    [IsoId("_Pm9o_04CEeiQHa-q1Uephw")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAsstForTrf")]
    #endif
    [IsoXmlTag("FinInstrmAsstForTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument68? FinancialInstrumentAssetForTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument68? FinancialInstrumentAssetForTransfer { get; init; } 
    #else
    public FinancialInstrument68? FinancialInstrumentAssetForTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the product transfer.
    /// </summary>
    [IsoId("_VcKYIZClEeiQvr1XXv37hw")]
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
