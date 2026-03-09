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
/// This component identifies the instance of the document exchanged.
/// </summary>
[IsoId("_jL4pQu5NEeCisYr99QEiWA_-884807516")]
[DisplayName("Payload Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PayloadDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PayloadDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PayloadDetails1( System.String reqPayloadIdentifier,System.DateTime reqCreationDateAndTime )
    {
        PayloadIdentifier = reqPayloadIdentifier;
        CreationDateAndTime = reqCreationDateAndTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// String of characters that uniquely identifies the file, which was delivered by the sender.
    /// </summary>
    [IsoId("_jL4pQ-5NEeCisYr99QEiWA_773260286")]
    [DisplayName("Payload Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyldIdr")]
    #endif
    [IsoXmlTag("PyldIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PayloadIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PayloadIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PayloadIdentifier { get; init; } 
    #else
    public System.String PayloadIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when the file was created by the sender.
    /// </summary>
    [IsoId("_jL4pRO5NEeCisYr99QEiWA_739714352")]
    [DisplayName("Creation Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtAndTm")]
    #endif
    [IsoXmlTag("CreDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateAndTime { get; init; } 
    #else
    public System.DateTime CreationDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Flag indicating if the file exchanged between the two business applications is possibly a duplicate. If this indicator is not present within the message, please note that the default value would be &quot;False&quot;.
    /// </summary>
    [IsoId("_jMCaQO5NEeCisYr99QEiWA_-217630319")]
    [DisplayName("Possible Duplicate Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PssblDplctFlg")]
    #endif
    [IsoXmlTag("PssblDplctFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PossibleDuplicateFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PossibleDuplicateFlag { get; init; } 
    #else
    public System.String? PossibleDuplicateFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
