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
/// Identification of the message number and the query identification.
/// </summary>
[IsoId("_dMtGoStbEeygfekJ15up0Q")]
[DisplayName("Document Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentIdentification54
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentIdentification54 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentIdentification54( System.String reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_dk150StbEeygfekJ15up0Q")]
    [DisplayName("Message Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNb")]
    #endif
    [IsoXmlTag("MsgNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    #else
    public DocumentNumber5Choice_? MessageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the query identification.
    /// </summary>
    [IsoId("_dk150ytbEeygfekJ15up0Q")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Reference { get; init; } 
    #else
    public System.String Reference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
