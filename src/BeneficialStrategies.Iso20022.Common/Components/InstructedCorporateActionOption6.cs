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
[IsoId("_lTehxTq5EeWQ1Y7f8kds2A")]
[DisplayName("Instructed Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedCorporateActionOption6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedCorporateActionOption6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedCorporateActionOption6( CorporateActionOption18Choice_ reqOptionType,BalanceFormat5Choice_ reqInstructedBalance,System.DateTime reqDeadlineDateTime,DeadlineCode3Choice_ reqDeadlineType )
    {
        OptionType = reqOptionType;
        InstructedBalance = reqInstructedBalance;
        DeadlineDateTime = reqDeadlineDateTime;
        DeadlineType = reqDeadlineType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_lgkikTq5EeWQ1Y7f8kds2A")]
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
    [IsoId("_lgkimTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption18Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption18Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption18Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption18Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_lgkioTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat5Choice_ InstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat5Choice_ InstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat5Choice_ InstructedBalance { get; init; } 
    #else
    public BalanceFormat5Choice_ InstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_lgkiqTq5EeWQ1Y7f8kds2A")]
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
    /// Any deadline chosen by the account servicer (service level agreement).
    /// </summary>
    [IsoId("_lgkisTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Deadline Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DdlnDtTm")]
    #endif
    [IsoXmlTag("DdlnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DeadlineDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DeadlineDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DeadlineDateTime { get; init; } 
    #else
    public System.DateTime DeadlineDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of deadline for instructing.
    /// </summary>
    [IsoId("_lgkiszq5EeWQ1Y7f8kds2A")]
    [DisplayName("Deadline Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DdlnTp")]
    #endif
    [IsoXmlTag("DdlnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeadlineCode3Choice_ DeadlineType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeadlineCode3Choice_ DeadlineType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeadlineCode3Choice_ DeadlineType { get; init; } 
    #else
    public DeadlineCode3Choice_ DeadlineType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
