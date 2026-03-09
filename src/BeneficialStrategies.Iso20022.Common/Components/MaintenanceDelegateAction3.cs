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
/// Information for the MTM to build or include delegated actions in the management plan of the POI.
/// </summary>
[IsoId("_xBB_gbC6EeamYaqfhG1ZuA")]
[DisplayName("Maintenance Delegate Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegateAction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Flag to indicate that the delegated actions have to be included in a periodic sequence of actions.
    /// </summary>
    [IsoId("_xMMGobC6EeamYaqfhG1ZuA")]
    [DisplayName("Periodic Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdcActn")]
    #endif
    [IsoXmlTag("PrdcActn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PeriodicAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PeriodicAction { get; init; } 
    #else
    public System.String? PeriodicAction { get; set; } 
    #endif
    
    /// <summary>
    /// Network address and parameters of the terminal manager host which will performs the delegated actions.
    /// </summary>
    [IsoId("_xMMGo7C6EeamYaqfhG1ZuA")]
    [DisplayName("TM Remote Access")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMRmotAccs")]
    #endif
    [IsoXmlTag("TMRmotAccs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters5? TMRemoteAccess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters5? TMRemoteAccess { get; init; } 
    #else
    public NetworkParameters5? TMRemoteAccess { get; set; } 
    #endif
    
    /// <summary>
    /// TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_xMMGpbC6EeamYaqfhG1ZuA")]
    [DisplayName("TMS Protocol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSPrtcol")]
    #endif
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TMSProtocol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TMSProtocol { get; init; } 
    #else
    public System.String? TMSProtocol { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_xMMGp7C6EeamYaqfhG1ZuA")]
    [DisplayName("TMS Protocol Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSPrtcolVrsn")]
    #endif
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TMSProtocolVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TMSProtocolVersion { get; init; } 
    #else
    public System.String? TMSProtocolVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Data set on which the delegated action has to be performed.
    /// </summary>
    [IsoId("_xMMGqbC6EeamYaqfhG1ZuA")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification6? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification6? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification6? DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of retry process when activation of the action fails.
    /// </summary>
    [IsoId("_xMMGq7C6EeamYaqfhG1ZuA")]
    [DisplayName("Re Try")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReTry")]
    #endif
    [IsoXmlTag("ReTry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessRetry2? ReTry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessRetry2? ReTry { get; init; } 
    #else
    public ProcessRetry2? ReTry { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to include in the maintenance action.
    /// </summary>
    [IsoId("_xMMGrbC6EeamYaqfhG1ZuA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AdditionalInformation { get; init; } 
    #else
    public System.Byte[]? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of action to include in the next MTM management plan.
    /// </summary>
    [IsoId("_xMMGr7C6EeamYaqfhG1ZuA")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSAction6? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSAction6? Action { get; init; } 
    #else
    public TMSAction6? Action { get; set; } 
    #endif
    
    
    #nullable disable
    
}
