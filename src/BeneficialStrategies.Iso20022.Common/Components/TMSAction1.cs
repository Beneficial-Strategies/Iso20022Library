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
[IsoId("_KsN70X1DEeCF8NjrBemJWQ_-405240554")]
[DisplayName("TMS Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSAction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSAction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSAction1( TerminalManagementAction1Code reqType,TerminalManagementActionTrigger1Code reqTrigger )
    {
        Type = reqType;
        Trigger = reqTrigger;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_KsN70n1DEeCF8NjrBemJWQ_-1093789784")]
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
    [IsoId("_KsN7031DEeCF8NjrBemJWQ_39936123")]
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
    [IsoId("_KsN71H1DEeCF8NjrBemJWQ_1755305315")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification2? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification2? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification2? DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_KsN71X1DEeCF8NjrBemJWQ_-687090561")]
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
    [IsoId("_KsN71n1DEeCF8NjrBemJWQ_1036887615")]
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
    [IsoId("_KsN7131DEeCF8NjrBemJWQ_-291991175")]
    [DisplayName("Time Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCond")]
    #endif
    [IsoXmlTag("TmCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessTiming1? TimeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessTiming1? TimeCondition { get; init; } 
    #else
    public ProcessTiming1? TimeCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_KsN72H1DEeCF8NjrBemJWQ_1120775201")]
    [DisplayName("Error Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrActn")]
    #endif
    [IsoXmlTag("ErrActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ErrorAction1? ErrorAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorAction1? ErrorAction { get; init; } 
    #else
    public ErrorAction1? ErrorAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
