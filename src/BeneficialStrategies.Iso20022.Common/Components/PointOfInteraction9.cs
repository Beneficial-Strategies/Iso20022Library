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
/// Point of interaction (POI) performing the transaction.
/// </summary>
[IsoId("_-ioIkdkGEeiojJsa6FYyew")]
[DisplayName("Point Of Interaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteraction9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteraction9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteraction9( GenericIdentification171 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_-sU3IdkGEeiojJsa6FYyew")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification171 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification171 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification171 Identification { get; init; } 
    #else
    public GenericIdentification171 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Common name assigned by the acquirer to the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_-sU3I9kGEeiojJsa6FYyew")]
    [DisplayName("System Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysNm")]
    #endif
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SystemName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemName { get; init; } 
    #else
    public System.String? SystemName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI (Point Of Interaction) terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_-sU3JdkGEeiojJsa6FYyew")]
    [DisplayName("Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpId")]
    #endif
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GroupIdentification { get; init; } 
    #else
    public System.String? GroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_-sU3J9kGEeiojJsa6FYyew")]
    [DisplayName("Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cpblties")]
    #endif
    [IsoXmlTag("Cpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionCapabilities8? Capabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionCapabilities8? Capabilities { get; init; } 
    #else
    public PointOfInteractionCapabilities8? Capabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Time zone name as defined by IANA (Internet Assigned Numbers Authority) in the time zone data base. America/Chicago or Europe/Paris are examples of time zone names.
    /// </summary>
    [IsoId("_-sU3KdkGEeiojJsa6FYyew")]
    [DisplayName("Time Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmZone")]
    #endif
    [IsoXmlTag("TmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TimeZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TimeZone { get; init; } 
    #else
    public System.String? TimeZone { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of integration of the POI terminal in the sale environment.
    /// </summary>
    [IsoId("_-sU3K9kGEeiojJsa6FYyew")]
    [DisplayName("Terminal Integration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlIntgtn")]
    #endif
    [IsoXmlTag("TermnlIntgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocationCategory3Code? TerminalIntegration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocationCategory3Code? TerminalIntegration { get; init; } 
    #else
    public LocationCategory3Code? TerminalIntegration { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_-sU3LdkGEeiojJsa6FYyew")]
    [DisplayName("Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmpnt")]
    #endif
    [IsoXmlTag("Cmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent9? Component { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent9? Component { get; init; } 
    #else
    public PointOfInteractionComponent9? Component { get; set; } 
    #endif
    
    
    #nullable disable
    
}
