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
/// Content of the Device Initialisation Card Reader Request message.
/// </summary>
[IsoId("_92ymMS8_Eeu125Ip9zFcsQ")]
[DisplayName("Device Initialisation Card Reader Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInitialisationCardReaderRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Flag to request a warm reset on a chip.
    /// </summary>
    [IsoId("_-DMqgS8_Eeu125Ip9zFcsQ")]
    [DisplayName("Warm Reset Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WarmRstFlg")]
    #endif
    [IsoXmlTag("WarmRstFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WarmResetFlag { get; init; } 
    #else
    public System.String? WarmResetFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("_-DMqgy8_Eeu125Ip9zFcsQ")]
    [DisplayName("Force Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ForceNtryMd")]
    #endif
    [IsoXmlTag("ForceNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading8Code? ForceEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading8Code? ForceEntryMode { get; init; } 
    #else
    public CardDataReading8Code? ForceEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to indicate the POI System to keep the card in the reader for a smart card.
    /// </summary>
    [IsoId("_-DMqhS8_Eeu125Ip9zFcsQ")]
    [DisplayName("Leave Card Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LeavCardFlg")]
    #endif
    [IsoXmlTag("LeavCardFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LeaveCardFlag { get; init; } 
    #else
    public System.String? LeaveCardFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum time in seconds that the POI has to wait for a card response.
    /// </summary>
    [IsoId("_-DMqhy8_Eeu125Ip9zFcsQ")]
    [DisplayName("Maximum Waiting Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxWtgTm")]
    #endif
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumWaitingTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumWaitingTime { get; init; } 
    #else
    public System.UInt64? MaximumWaitingTime { get; set; } 
    #endif
    
    /// <summary>
    /// Information to display.
    /// </summary>
    [IsoId("_-DMqiS8_Eeu125Ip9zFcsQ")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage8? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage8? DisplayOutput { get; init; } 
    #else
    public ActionMessage8? DisplayOutput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
