// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document as well as the document number and type of link.
/// </summary>
[IsoId("_chUbxZKQEeWHWpTQn1FFVg")]
[DisplayName("Document Identification")]
public partial record DocumentIdentification38
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    [IsoId("_chUbx5KQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification4Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    [IsoId("_chUbz5KQEeWHWpTQn1FFVg")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public DocumentNumber6Choice_? DocumentNumber { get; init; } 
    
    /// <summary>
    /// Specifies when this document is to be processed relative to another referred document.
    /// </summary>
    [IsoId("_chUb15KQEeWHWpTQn1FFVg")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition10Choice_? LinkageType { get; init; } 
    
    
    #nullable disable
    
}
