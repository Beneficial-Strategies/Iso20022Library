// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

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
public partial record QualifiedDocumentInformation1
{
    #nullable enable
    
    /// <summary>
    /// Local identification to be used in IDREFs in this message.
    /// </summary>
    [IsoId("_OTgzMjMz-AOSNFX-8224494")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ID)]
    public required IsoID Identification { get; init; } 
    
    /// <summary>
    /// Party issuing the reference.
    /// </summary>
    [IsoId("_OTgzMjM0-AOSNFX-8224494")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    
    /// <summary>
    /// Unambiguous identifier relative to the issuing party of a list of items.
    /// </summary>
    [IsoId("_OTgzMjM1-AOSNFX-8224494")]
    [DisplayName("Item List Identifier")]
    [IsoXmlTag("ItmListIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ItemListIdentifier { get; init; } 
    
    /// <summary>
    /// Unambiguous identifier relative to the issuing party of an item (independent of any list).
    /// </summary>
    [IsoId("_OTgzMjM2-AOSNFX-8224494")]
    [DisplayName("Item Identifier")]
    [IsoXmlTag("ItmIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ItemIdentifier { get; init; } 
    
    /// <summary>
    /// Date of document or element. This may be used as a control value to indicate a specific version.
    /// </summary>
    [IsoId("_OTgzMjM3-AOSNFX-8224494")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Identification of the version of the document or element. This may be used as a control value to indicate a specific version.
    /// </summary>
    [IsoId("_OTgzMjM4-AOSNFX-8224494")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? Version { get; init; } 
    
    /// <summary>
    /// If true, document is in its original form, otherwise it is a scanned version.
    /// </summary>
    [IsoId("_OTgzMjM5-AOSNFX-8224494")]
    [DisplayName("Electronic Original")]
    [IsoXmlTag("ElctrncOrgnl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ElectronicOriginal { get; init; } 
    
    /// <summary>
    /// Cryptographic hash of the document.
    /// </summary>
    [IsoId("_OTgzMjQx-AOSNFX-8224494")]
    [DisplayName("Digest")]
    [IsoXmlTag("Dgst")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AlgorithmAndDigest1> Digest { get; init; } = new ValueList<AlgorithmAndDigest1>(){};
    
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_OTgzMjQy-AOSNFX-8224494")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    public ExternalDocumentType1Code? DocumentType { get; init; } 
    
    /// <summary>
    /// URL (Uniform Resource Locator) where the document can be found.
    /// </summary>
    [IsoId("_OTgzMjQz-AOSNFX-8224494")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? URL { get; init; } 
    
    /// <summary>
    /// Attached file for this document. The file must be in a self-describing format.
    /// </summary>
    [IsoId("_OTgzMjQ0-AOSNFX-8224494")]
    [DisplayName("Attached File")]
    [IsoXmlTag("AttchdFile")]
    public BinaryFile1? AttachedFile { get; init; } 
    
    
    #nullable disable
    
}
