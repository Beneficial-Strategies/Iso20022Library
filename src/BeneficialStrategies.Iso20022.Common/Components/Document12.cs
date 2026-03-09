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
[IsoId("_Q1Ld4XR1EeiH1ZOt2UD8vQ")]
[DisplayName("Document")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Document12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Document12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Document12( DocumentType1Choice_ reqType,System.String reqIdentification,DateAndDateTime2Choice_ reqIssueDate,DocumentFormat1Choice_ reqFormat,System.Byte[] reqEnclosure )
    {
        Type = reqType;
        Identification = reqIdentification;
        IssueDate = reqIssueDate;
        Format = reqFormat;
        Enclosure = reqEnclosure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of document or template.
    /// </summary>
    [IsoId("_Q_AvUXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentType1Choice_ Type { get; init; } 
    #else
    public DocumentType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the document or template.
    /// </summary>
    [IsoId("_Q_AvU3R1EeiH1ZOt2UD8vQ")]
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
    /// Issue date or date time of the document.
    /// </summary>
    [IsoId("_3iRlYXiJEeidzqjNEfehPg")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ IssueDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Name of document or transaction, for example, tax invoice.
    /// </summary>
    [IsoId("_E_8EYniKEeidzqjNEfehPg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for a language used in the document.
    /// </summary>
    [IsoId("_E_8EY3iKEeidzqjNEfehPg")]
    [DisplayName("Language Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LangCd")]
    #endif
    [IsoXmlTag("LangCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? LanguageCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LanguageCode { get; init; } 
    #else
    public string? LanguageCode { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the document or template, such as PDF, XML, XSLT.
    /// </summary>
    [IsoId("_Q_AvVXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentFormat1Choice_ Format { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentFormat1Choice_ Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentFormat1Choice_ Format { get; init; } 
    #else
    public DocumentFormat1Choice_ Format { get; set; } 
    #endif
    
    /// <summary>
    /// Technical name of the file.
    /// </summary>
    [IsoId("_ZEDS8XiKEeidzqjNEfehPg")]
    [DisplayName("File Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileNm")]
    #endif
    [IsoXmlTag("FileNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? FileName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FileName { get; init; } 
    #else
    public System.String? FileName { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the enclosed binary file.
    /// </summary>
    [IsoId("_Q_AvWXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature3? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature3? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature3? DigitalSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Binary file representing the enclosed document or template, such as a PDF file, image file, XML file, MT message.
    /// </summary>
    [IsoId("_Q_AvV3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Enclosure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nclsr")]
    #endif
    [IsoXmlTag("Nclsr")]
    [IsoSimpleType(IsoSimpleType.Max10MbBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10MbBinary Enclosure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Enclosure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Enclosure { get; init; } 
    #else
    public System.Byte[] Enclosure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
