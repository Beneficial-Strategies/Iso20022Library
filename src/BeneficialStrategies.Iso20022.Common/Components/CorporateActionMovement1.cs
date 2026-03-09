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
/// Provides information about the movement instruction.
/// </summary>
[IsoId("_UIh5p9p-Ed-ak6NoX_4Aeg_378115287")]
[DisplayName("Corporate Action Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovement1( DistributionInstructionType1Code reqOrderType,System.String reqHighPriorityIndicator,System.DateOnly reqRequestedExecutionDate )
    {
        OrderType = reqOrderType;
        HighPriorityIndicator = reqHighPriorityIndicator;
        RequestedExecutionDate = reqRequestedExecutionDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of movement instruction.
    /// </summary>
    [IsoId("_UIh5qNp-Ed-ak6NoX_4Aeg_-2043026968")]
    [DisplayName("Order Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrTp")]
    #endif
    [IsoXmlTag("OrdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DistributionInstructionType1Code OrderType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DistributionInstructionType1Code OrderType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionInstructionType1Code OrderType { get; init; } 
    #else
    public DistributionInstructionType1Code OrderType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the movement is a high priority or not.|Meaning when true: High priority|Meaning when false: Standard.
    /// </summary>
    [IsoId("_UIh5qdp-Ed-ak6NoX_4Aeg_1947921085")]
    [DisplayName("High Priority Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghPrtyInd")]
    #endif
    [IsoXmlTag("HghPrtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator HighPriorityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String HighPriorityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HighPriorityIndicator { get; init; } 
    #else
    public System.String HighPriorityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UIh5qtp-Ed-ak6NoX_4Aeg_1390292817")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionNumber { get; init; } 
    #else
    public System.String? OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UIh5q9p-Ed-ak6NoX_4Aeg_1390292847")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the distribution movement must be executed.
    /// </summary>
    [IsoId("_UIh5rNp-Ed-ak6NoX_4Aeg_1481723517")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate RequestedExecutionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly RequestedExecutionDate { get; init; } 
    #else
    public System.DateOnly RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_UIrqoNp-Ed-ak6NoX_4Aeg_-780577191")]
    [DisplayName("Account Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrId")]
    #endif
    [IsoXmlTag("AcctOwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_UIrqodp-Ed-ak6NoX_4Aeg_1208775765")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the confirmed balance, ie, the balance to which the credit of the outturned resources applies.
    /// </summary>
    [IsoId("_UIrqotp-Ed-ak6NoX_4Aeg_-298927794")]
    [DisplayName("Confirmed Balance Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdBalSctiesQty")]
    #endif
    [IsoXmlTag("ConfdBalSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? ConfirmedBalanceSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? ConfirmedBalanceSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? ConfirmedBalanceSecuritiesQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
