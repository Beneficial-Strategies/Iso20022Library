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
/// Business reference(s) to one or more relevant messages previously sent by other parties, or by the same party issuing this message.
/// </summary>
[IsoId("_hl9VYZb4Eee4htziCyV8eA")]
[DisplayName("Message Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageReference1( System.String reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to a previous message having a business relevance with this message.
    /// </summary>
    [IsoId("_hub785b4Eee4htziCyV8eA")]
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
    
    /// <summary>
    /// Name of the message which contained the given additional reference as its message reference.
    /// </summary>
    [IsoId("_hub79Zb4Eee4htziCyV8eA")]
    [DisplayName("Message Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNm")]
    #endif
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MessageName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageName { get; init; } 
    #else
    public System.String? MessageName { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initially assigned the given additional reference.
    /// </summary>
    [IsoId("_hub795b4Eee4htziCyV8eA")]
    [DisplayName("Reference Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefIssr")]
    #endif
    [IsoXmlTag("RefIssr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? ReferenceIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? ReferenceIssuer { get; init; } 
    #else
    public PartyIdentification136? ReferenceIssuer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
