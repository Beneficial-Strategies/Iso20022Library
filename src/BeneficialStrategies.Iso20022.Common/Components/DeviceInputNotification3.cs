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
/// Content of the Input notification message.
/// </summary>
[IsoId("_G2basS9AEeu125Ip9zFcsQ")]
[DisplayName("Device Input Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInputNotification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceInputNotification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceInputNotification3( System.String reqExchangeIdentification,ActionMessage8 reqOutputContent )
    {
        ExchangeIdentification = reqExchangeIdentification;
        OutputContent = reqOutputContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message main identifier.
    /// </summary>
    [IsoId("_HC1fAS9AEeu125Ip9zFcsQ")]
    [DisplayName("Exchange Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgId")]
    #endif
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExchangeIdentification { get; init; } 
    #else
    public System.String ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    [IsoId("_HC1fAy9AEeu125Ip9zFcsQ")]
    [DisplayName("Output Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptCntt")]
    #endif
    [IsoXmlTag("OutptCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActionMessage8 OutputContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActionMessage8 OutputContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage8 OutputContent { get; init; } 
    #else
    public ActionMessage8 OutputContent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
