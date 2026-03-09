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
/// Information about a document.
/// </summary>
[IsoId("_96r9QXltEeG7BsjMvd1mEw_1701053345")]
[DisplayName("Document")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Document9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Document9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Document9( UndertakingDocumentType1Choice_ reqType,System.String reqIdentification,System.Byte[] reqEnclosure )
    {
        Type = reqType;
        Identification = reqIdentification;
        Enclosure = reqEnclosure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of document or template.
    /// </summary>
    [IsoId("_96r9QnltEeG7BsjMvd1mEw_-1450988527")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingDocumentType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingDocumentType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingDocumentType1Choice_ Type { get; init; } 
    #else
    public UndertakingDocumentType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the document or template.
    /// </summary>
    [IsoId("_96r9Q3ltEeG7BsjMvd1mEw_1198711334")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the document or template, such as PDF, XML, XSLT.
    /// </summary>
    [IsoId("_96r9RHltEeG7BsjMvd1mEw_-1792505725")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentFormat1Choice_? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentFormat1Choice_? Format { get; init; } 
    #else
    public DocumentFormat1Choice_? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Binary file representing the enclosed document or template, such as a PDF file, image file, XML file, MT message.
    /// </summary>
    [IsoId("_961HMHltEeG7BsjMvd1mEw_-1712866325")]
    [DisplayName("Enclosure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nclsr")]
    #endif
    [IsoXmlTag("Nclsr")]
    [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2MBBinary Enclosure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Enclosure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Enclosure { get; init; } 
    #else
    public System.Byte[] Enclosure { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the enclosed binary file.
    /// </summary>
    [IsoId("_961HMXltEeG7BsjMvd1mEw_-730056321")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
