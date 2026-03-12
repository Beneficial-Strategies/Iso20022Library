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
[IsoId("_ThCb29p-Ed-ak6NoX_4Aeg_15602052")]
[DisplayName("Document Identification")]
public partial record DocumentIdentification13
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    [IsoId("_ThCb3Np-Ed-ak6NoX_4Aeg_-1539857264")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification1Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    [IsoId("_ThMM0Np-Ed-ak6NoX_4Aeg_1647919087")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public DocumentNumber1Choice_? DocumentNumber { get; init; } 
    
    /// <summary>
    /// Specifies when this document is to be processed relative to an other referred document.
    /// </summary>
    [IsoId("_ThMM0dp-Ed-ak6NoX_4Aeg_2086969518")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition1Choice_? LinkageType { get; init; } 
    
    
    #nullable disable
    
}
