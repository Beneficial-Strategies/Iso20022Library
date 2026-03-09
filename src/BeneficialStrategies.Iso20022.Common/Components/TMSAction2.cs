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
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[IsoId("_Y2MKQR3ZEeKKrOIoqWglDw")]
[DisplayName("TMS Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSAction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSAction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSAction2( TerminalManagementAction1Code reqType,TerminalManagementActionTrigger1Code reqTrigger )
    {
        Type = reqType;
        Trigger = reqTrigger;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_ZCYzMR3ZEeKKrOIoqWglDw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction1Code Type { get; init; } 
    #else
    public TerminalManagementAction1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Communication parameters of the terminal management system to contact.
    /// </summary>
    [IsoId("_ZCYzNR3ZEeKKrOIoqWglDw")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters1? Address { get; init; } 
    #else
    public NetworkParameters1? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_ZCYzOR3ZEeKKrOIoqWglDw")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification3? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification3? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification3? DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_ZCYzPR3ZEeKKrOIoqWglDw")]
    [DisplayName("Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trggr")]
    #endif
    [IsoXmlTag("Trggr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementActionTrigger1Code Trigger { get; init; } 
    #else
    public TerminalManagementActionTrigger1Code Trigger { get; set; } 
    #endif
    
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_ZCYzQR3ZEeKKrOIoqWglDw")]
    [DisplayName("Additional Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPrc")]
    #endif
    [IsoXmlTag("AddtlPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    #else
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_ZCYzRR3ZEeKKrOIoqWglDw")]
    [DisplayName("Time Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCond")]
    #endif
    [IsoXmlTag("TmCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessTiming2? TimeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessTiming2? TimeCondition { get; init; } 
    #else
    public ProcessTiming2? TimeCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_racKMCmuEeKIjpr--01h3Q")]
    [DisplayName("TM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllng")]
    #endif
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? TMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TMChallenge { get; init; } 
    #else
    public System.Byte[]? TMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_GhvusCmvEeKIjpr--01h3Q")]
    [DisplayName("Key Encipherment Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyNcphrmntCert")]
    #endif
    [IsoXmlTag("KeyNcphrmntCert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? KeyEnciphermentCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? KeyEnciphermentCertificate { get; init; } 
    #else
    public System.Byte[]? KeyEnciphermentCertificate { get; set; } 
    #endif
    
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_ZCYzSR3ZEeKKrOIoqWglDw")]
    [DisplayName("Error Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrActn")]
    #endif
    [IsoXmlTag("ErrActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ErrorAction2? ErrorAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorAction2? ErrorAction { get; init; } 
    #else
    public ErrorAction2? ErrorAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
