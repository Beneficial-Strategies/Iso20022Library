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
/// Identification of the message and individual instruction(s) for which the cancellation was requested.
/// </summary>
[IsoId("_KPVWwDUBEe2tRf29bleifQ")]
[DisplayName("Meeting Instruction Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingInstructionIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionIdentification1( System.String reqMeetingInstructionIdentification,System.String reqSingleInstructionIdentification )
    {
        MeetingInstructionIdentification = reqMeetingInstructionIdentification;
        SingleInstructionIdentification = reqSingleInstructionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the previous meeting instruction message containing the individual instruction(s) for which the cancellation was requested.
    /// </summary>
    [IsoId("_TeJ2wDUBEe2tRf29bleifQ")]
    [DisplayName("Meeting Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgInstrId")]
    #endif
    [IsoXmlTag("MtgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MeetingInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MeetingInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MeetingInstructionIdentification { get; init; } 
    #else
    public System.String MeetingInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the individual instruction for which the cancellation was requested.
    /// </summary>
    [IsoId("_XMIkYDUBEe2tRf29bleifQ")]
    [DisplayName("Single Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SnglInstrId")]
    #endif
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SingleInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SingleInstructionIdentification { get; init; } 
    #else
    public System.String SingleInstructionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
