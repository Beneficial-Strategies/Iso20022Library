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
/// Defines a signing party and a digital signature made by this party.
/// </summary>
[IsoId("_OTgzMjI3-AOSNFX-8224493")]
[DisplayName("Qualified Party And XML Signature")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QualifiedPartyAndXMLSignature1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QualifiedPartyAndXMLSignature1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QualifiedPartyAndXMLSignature1( SignatureEnvelope reqSignature )
    {
        Signature = reqSignature;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the signing party.
    /// </summary>
    [IsoId("_OTgzMjc0-AOSNFX-8224496")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Party { get; init; } 
    #else
    public QualifiedPartyIdentification1? Party { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature in XML-DSIG format and reference to signing party.
    /// </summary>
    [IsoId("_OTgzMjc2-AOSNFX-8224496")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignatureEnvelope Signature { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SignatureEnvelope Signature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignatureEnvelope Signature { get; init; } 
    #else
    public SignatureEnvelope Signature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
