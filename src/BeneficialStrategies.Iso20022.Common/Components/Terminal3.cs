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
[IsoId("_e4IxaewNEeiMkKo2clXHdQ")]
[DisplayName("Terminal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Terminal3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_e4IxcewNEeiMkKo2clXHdQ")]
    [DisplayName("Terminal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlId")]
    #endif
    [IsoXmlTag("TermnlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalIdentification2? TerminalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalIdentification2? TerminalIdentification { get; init; } 
    #else
    public TerminalIdentification2? TerminalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the terminal.
    /// </summary>
    [IsoId("_e4Ixa-wNEeiMkKo2clXHdQ")]
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
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-2
    /// </summary>
    [IsoId("_e4Ixb-wNEeiMkKo2clXHdQ")]
    [DisplayName("Cardholder Verification Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrVrfctnCpblty")]
    #endif
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; } 
    #else
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    [IsoId("_e4IxbuwNEeiMkKo2clXHdQ")]
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
    /// True: The terminal is operated outdoor.
    /// False: The terminal is operated indoor.
    /// </summary>
    [IsoId("_e4IxbOwNEeiMkKo2clXHdQ")]
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
    [IsoId("_e4IxbewNEeiMkKo2clXHdQ")]
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
    [IsoId("_e4IxcOwNEeiMkKo2clXHdQ")]
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
    [IsoId("_e4IxauwNEeiMkKo2clXHdQ")]
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
