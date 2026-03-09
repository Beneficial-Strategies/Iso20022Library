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
/// Details of the Financial Institution responding to the request.
/// </summary>
[IsoId("_SuwKHAEcEeCQm6a_G2yO_w_2135472976")]
[DisplayName("Responder Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResponderDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResponderDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResponderDetails1( System.DateTime reqDateTimeStamp,System.String reqResponder )
    {
        DateTimeStamp = reqDateTimeStamp;
        Responder = reqResponder;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the response was created.
    /// </summary>
    [IsoId("_SuwKHQEcEeCQm6a_G2yO_w_-495861824")]
    [DisplayName("Date Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtTmStmp")]
    #endif
    [IsoXmlTag("DtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime DateTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime DateTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime DateTimeStamp { get; init; } 
    #else
    public System.DateTime DateTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the responder.
    /// </summary>
    [IsoId("_Su5UAAEcEeCQm6a_G2yO_w_569448861")]
    [DisplayName("Responder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspndr")]
    #endif
    [IsoXmlTag("Rspndr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier Responder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Responder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Responder { get; init; } 
    #else
    public System.String Responder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
