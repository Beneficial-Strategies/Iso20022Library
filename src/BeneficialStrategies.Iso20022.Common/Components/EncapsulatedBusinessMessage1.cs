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
/// Defines an encapsulated form of an ISO 20022 message and, if present, its associated Business Application Header. The encapsulation guarantees uniqueness of ID/IDREFs though the use of the Prefix element. This element can be added during message preparation to ID/IDREFs. In order to verify the signature in the Hdr element or inside the encapsulated message, for each occurrence of an ID orIDREF that possesses the same value as a prefix, the prefix part is removed before signature verification. This is not done for surrounding signatures.
/// </summary>
[IsoId("_OTgzMTky-AOSNFX-8224490")]
[DisplayName("Encapsulated Business Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EncapsulatedBusinessMessage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EncapsulatedBusinessMessage1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EncapsulatedBusinessMessage1( System.String reqPartial,StrictPayload reqMessage )
    {
        Partial = reqPartial;
        Message = reqMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The Business Application Header associated to the encapsulated message if it exists.
    /// </summary>
    [IsoId("_NzE0NzI0-AOSNFX-5096924")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessApplicationHeader1? Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessApplicationHeader1? Header { get; init; } 
    #else
    public BusinessApplicationHeader1? Header { get; set; } 
    #endif
    
    /// <summary>
    /// Prefix of ID/IDREFs in the encapsulated message to be removed before signature verification.
    /// </summary>
    [IsoId("_NzE0NzI1-AOSNFX-5096924")]
    [DisplayName("Prefix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prfx")]
    #endif
    [IsoXmlTag("Prfx")]
    [IsoSimpleType(IsoSimpleType.ID)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoID? Prefix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Prefix { get; init; } 
    #else
    public System.String? Prefix { get; set; } 
    #endif
    
    /// <summary>
    /// If yes, the Msg element contains only a subset of the original message.
    /// </summary>
    [IsoId("_NzE0NzI2-AOSNFX-5096924")]
    [DisplayName("Partial")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtl")]
    #endif
    [IsoXmlTag("Prtl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Partial { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Partial { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Partial { get; init; } 
    #else
    public System.String Partial { get; set; } 
    #endif
    
    /// <summary>
    /// The encapsulated ISO 20022 message.
    /// </summary>
    [IsoId("_NzE0NzI3-AOSNFX-5096924")]
    [DisplayName("Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Msg")]
    #endif
    [IsoXmlTag("Msg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StrictPayload Message { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StrictPayload Message { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StrictPayload Message { get; init; } 
    #else
    public StrictPayload Message { get; set; } 
    #endif
    
    
    #nullable disable
    
}
