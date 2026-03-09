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
/// Payment terminal or ATM performing the transaction
/// </summary>
[IsoId("_O6I3sECOEeeXpbqDpLawug")]
[DisplayName("Terminal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Terminal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Terminal1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Terminal1( TerminalIdentification1 reqTerminalIdentification )
    {
        TerminalIdentification = reqTerminalIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_nLdGgECOEeeXpbqDpLawug")]
    [DisplayName("Terminal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlId")]
    #endif
    [IsoXmlTag("TermnlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalIdentification1 TerminalIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalIdentification1 TerminalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalIdentification1 TerminalIdentification { get; init; } 
    #else
    public TerminalIdentification1 TerminalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of terminal.
    /// </summary>
    [IsoId("_6H0FARqYEeqH1IQNpbVpEw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalType1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalType1Code? Type { get; init; } 
    #else
    public TerminalType1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of terminal.
    /// </summary>
    [IsoId("_7oE94RqYEeqH1IQNpbVpEw")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the terminal
    /// </summary>
    [IsoId("_CCx9YEqXEeenp6hmNprBHg")]
    [DisplayName("Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cpblties")]
    #endif
    [IsoXmlTag("Cpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Capabilities1? Capabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Capabilities1? Capabilities { get; init; } 
    #else
    public Capabilities1? Capabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    [IsoId("_Ugjk0RV9EeiTbY4xN42WAw")]
    [DisplayName("Terminal Integration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlIntgtn")]
    #endif
    [IsoXmlTag("TermnlIntgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; init; } 
    #else
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the terminal is operated outdoor or indoor at the point of service.
    /// True: The terminal is operated outdoor
    /// False: The terminal is operated indoor
    /// </summary>
    [IsoId("_WkEUsRV9EeiTbY4xN42WAw")]
    [DisplayName("Outdoor Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutdrInd")]
    #endif
    [IsoXmlTag("OutdrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OutdoorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OutdoorIndicator { get; init; } 
    #else
    public System.String? OutdoorIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the terminal is operated on- or off-premises at the point of service.
    /// True: The terminal is operated off premises.
    /// False: The terminal is operated on premises.
    /// ISO 8583:93 bit 22-4, ISO 8583:2003 bit 22-3.
    /// </summary>
    [IsoId("_YegoIRV9EeiTbY4xN42WAw")]
    [DisplayName("Off Premises Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffPrmissInd")]
    #endif
    [IsoXmlTag("OffPrmissInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OffPremisesIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OffPremisesIndicator { get; init; } 
    #else
    public System.String? OffPremisesIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction was performed on board.
    /// True: The terminal is located on board.
    /// False: The terminal is not located on board.
    /// </summary>
    [IsoId("_qGJ6YdIhEeirx-13kKhDlQ")]
    [DisplayName("On Board Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnBrdInd")]
    #endif
    [IsoXmlTag("OnBrdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OnBoardIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OnBoardIndicator { get; init; } 
    #else
    public System.String? OnBoardIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the transactions.
    /// </summary>
    [IsoId("_LXOZ0NIfEeirx-13kKhDlQ")]
    [DisplayName("POI Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICmpnt")]
    #endif
    [IsoXmlTag("POICmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent8? POIComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent8? POIComponent { get; init; } 
    #else
    public PointOfInteractionComponent8? POIComponent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
