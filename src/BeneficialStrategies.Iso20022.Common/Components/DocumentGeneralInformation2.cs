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
/// General information that unambiguously identifies a document, such as identification number and issue date time.
/// </summary>
[IsoId("_S-ZIkAEcEeCQm6a_G2yO_w_-1398499112")]
[DisplayName("Document General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentGeneralInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentGeneralInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentGeneralInformation2( ExternalDocumentType1Code reqDocumentType,System.String reqDocumentNumber )
    {
        DocumentType = reqDocumentType;
        DocumentNumber = reqDocumentNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_S-ZIkQEcEeCQm6a_G2yO_w_-1690456850")]
    [DisplayName("Document Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocTp")]
    #endif
    [IsoXmlTag("DocTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentType1Code DocumentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentType1Code DocumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentType1Code DocumentType { get; init; } 
    #else
    public ExternalDocumentType1Code DocumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_S-ZIkgEcEeCQm6a_G2yO_w_-1512338178")]
    [DisplayName("Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocNb")]
    #endif
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DocumentNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DocumentNumber { get; init; } 
    #else
    public System.String DocumentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_S-ZIkwEcEeCQm6a_G2yO_w_-166388554")]
    [DisplayName("Sender Receiver Sequence Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrRcvrSeqId")]
    #endif
    [IsoXmlTag("SndrRcvrSeqId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SenderReceiverSequenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderReceiverSequenceIdentification { get; init; } 
    #else
    public System.String? SenderReceiverSequenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_S-ZIlAEcEeCQm6a_G2yO_w_-1163460907")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssueDate { get; init; } 
    #else
    public System.DateOnly? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// URL (Uniform Resource Locator) where the document can be found.
    /// </summary>
    [IsoId("_S-ZIlQEcEeCQm6a_G2yO_w_2134434036")]
    [DisplayName("URL")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URL")]
    #endif
    [IsoXmlTag("URL")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? URL { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URL { get; init; } 
    #else
    public System.String? URL { get; set; } 
    #endif
    
    /// <summary>
    /// Attached binary file for this document.
    /// </summary>
    [IsoId("_S-ZIlgEcEeCQm6a_G2yO_w_1137361683")]
    [DisplayName("Attached Binary File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchdBinryFile")]
    #endif
    [IsoXmlTag("AttchdBinryFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BinaryFile1? AttachedBinaryFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BinaryFile1? AttachedBinaryFile { get; init; } 
    #else
    public BinaryFile1? AttachedBinaryFile { get; set; } 
    #endif
    
    
    #nullable disable
    
}
