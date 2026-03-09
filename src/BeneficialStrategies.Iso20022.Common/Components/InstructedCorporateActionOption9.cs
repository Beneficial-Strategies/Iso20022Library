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
/// Provides corporate action option details about total instructed balance.
/// </summary>
[IsoId("_qrHuZc3iEee5nJBZsW8MFQ")]
[DisplayName("Instructed Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedCorporateActionOption9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedCorporateActionOption9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedCorporateActionOption9( CorporateActionOption23Choice_ reqOptionType,BalanceFormat7Choice_ reqInstructedBalance,CorporateActionEventDeadlines2 reqEventDeadlines )
    {
        OptionType = reqOptionType;
        InstructedBalance = reqInstructedBalance;
        EventDeadlines = reqEventDeadlines;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_qrHuZ83iEee5nJBZsW8MFQ")]
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
    [IsoId("_qrHub83iEee5nJBZsW8MFQ")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption23Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption23Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption23Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption23Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_qrHud83iEee5nJBZsW8MFQ")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat7Choice_ InstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat7Choice_ InstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat7Choice_ InstructedBalance { get; init; } 
    #else
    public BalanceFormat7Choice_ InstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_qrHuf83iEee5nJBZsW8MFQ")]
    [DisplayName("Default Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltActn")]
    #endif
    [IsoXmlTag("DfltActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    #else
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_qrHuh83iEee5nJBZsW8MFQ")]
    [DisplayName("Event Deadlines")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDdlns")]
    #endif
    [IsoXmlTag("EvtDdlns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventDeadlines2 EventDeadlines { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventDeadlines2 EventDeadlines { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventDeadlines2 EventDeadlines { get; init; } 
    #else
    public CorporateActionEventDeadlines2 EventDeadlines { get; set; } 
    #endif
    
    
    #nullable disable
    
}
