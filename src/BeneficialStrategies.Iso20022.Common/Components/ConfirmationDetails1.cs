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
/// Reference of the PayInSchedule being confirmed. This is the Message Identification element from the Report Data sequence of the Pay In Schedule message.
/// </summary>
[IsoId("_SvM2AgEcEeCQm6a_G2yO_w_-502764871")]
[DisplayName("Confirmation Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConfirmationDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ConfirmationDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ConfirmationDetails1( System.String reqPayInScheduleReference )
    {
        PayInScheduleReference = reqPayInScheduleReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the pay in schedule confirmed.
    /// </summary>
    [IsoId("_SvM2AwEcEeCQm6a_G2yO_w_-1406647983")]
    [DisplayName("Pay In Schedule Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PayInSchdlRef")]
    #endif
    [IsoXmlTag("PayInSchdlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PayInScheduleReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PayInScheduleReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PayInScheduleReference { get; init; } 
    #else
    public System.String PayInScheduleReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
