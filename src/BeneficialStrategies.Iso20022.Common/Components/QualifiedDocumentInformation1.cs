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
/// Specifies an identification of a document assigned by and relative to the issuing party (of the identification).
/// Optionally, the component can contain a copy of the identified document and a URI/URL (Universal Resource Information/Location) facilitating retrieval of the document.
/// The component may also contain a cryptographic hash of the referenced document.
/// Financial items are identified by three parts:
/// (1) the creator of the document,
/// (2) an identification of a dossier, and
/// (3) an identification of a financial item.
/// The two latter identifiers are independent permitting to identify the same item in several lists.
/// The element identification is of schema type ID, it can be referenced by IDREF typed elements (composite=false).
/// </summary>
[IsoId("_OTgzMjA0-AOSNFX-8224491")]
[DisplayName("Qualified Document Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QualifiedDocumentInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QualifiedDocumentInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QualifiedDocumentInformation1( System.String reqIdentification,System.String reqElectronicOriginal )
    {
        Identification = reqIdentification;
        ElectronicOriginal = reqElectronicOriginal;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Local identification to be used in IDREFs in this message.
    /// </summary>
    [IsoId("_OTgzMjMz-AOSNFX-8224494")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ID)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoID Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party issuing the reference.
    /// </summary>
    [IsoId("_OTgzMjM0-AOSNFX-8224494")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    #else
    public QualifiedPartyIdentification1? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identifier relative to the issuing party of a list of items.
    /// </summary>
    [IsoId("_OTgzMjM1-AOSNFX-8224494")]
    [DisplayName("Item List Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmListIdr")]
    #endif
    [IsoXmlTag("ItmListIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ItemListIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ItemListIdentifier { get; init; } 
    #else
    public System.String? ItemListIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identifier relative to the issuing party of an item (independent of any list).
    /// </summary>
    [IsoId("_OTgzMjM2-AOSNFX-8224494")]
    [DisplayName("Item Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmIdr")]
    #endif
    [IsoXmlTag("ItmIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ItemIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ItemIdentifier { get; init; } 
    #else
    public System.String? ItemIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date of document or element. This may be used as a control value to indicate a specific version.
    /// </summary>
    [IsoId("_OTgzMjM3-AOSNFX-8224494")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the version of the document or element. This may be used as a control value to indicate a specific version.
    /// </summary>
    [IsoId("_OTgzMjM4-AOSNFX-8224494")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6Text? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Version { get; init; } 
    #else
    public System.String? Version { get; set; } 
    #endif
    
    /// <summary>
    /// If true, document is in its original form, otherwise it is a scanned version.
    /// </summary>
    [IsoId("_OTgzMjM5-AOSNFX-8224494")]
    [DisplayName("Electronic Original")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncOrgnl")]
    #endif
    [IsoXmlTag("ElctrncOrgnl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ElectronicOriginal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ElectronicOriginal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ElectronicOriginal { get; init; } 
    #else
    public System.String ElectronicOriginal { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic hash of the document.
    /// </summary>
    [IsoId("_OTgzMjQx-AOSNFX-8224494")]
    [DisplayName("Digest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dgst")]
    #endif
    [IsoXmlTag("Dgst")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AlgorithmAndDigest1> Digest { get; init; } = new ValueList<AlgorithmAndDigest1>(){};
    
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_OTgzMjQy-AOSNFX-8224494")]
    [DisplayName("Document Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocTp")]
    #endif
    [IsoXmlTag("DocTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalDocumentType1Code? DocumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentType1Code? DocumentType { get; init; } 
    #else
    public ExternalDocumentType1Code? DocumentType { get; set; } 
    #endif
    
    /// <summary>
    /// URL (Uniform Resource Locator) where the document can be found.
    /// </summary>
    [IsoId("_OTgzMjQz-AOSNFX-8224494")]
    [DisplayName("URL")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URL")]
    #endif
    [IsoXmlTag("URL")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? URL { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URL { get; init; } 
    #else
    public System.String? URL { get; set; } 
    #endif
    
    /// <summary>
    /// Attached file for this document. The file must be in a self-describing format.
    /// </summary>
    [IsoId("_OTgzMjQ0-AOSNFX-8224494")]
    [DisplayName("Attached File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchdFile")]
    #endif
    [IsoXmlTag("AttchdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BinaryFile1? AttachedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BinaryFile1? AttachedFile { get; init; } 
    #else
    public BinaryFile1? AttachedFile { get; set; } 
    #endif
    
    
    #nullable disable
    
}
