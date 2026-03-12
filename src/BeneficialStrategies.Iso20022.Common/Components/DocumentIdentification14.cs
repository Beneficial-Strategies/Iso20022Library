// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document as well as the document number.
/// </summary>
[IsoId("_ThCb0tp-Ed-ak6NoX_4Aeg_-2018672131")]
[DisplayName("Document Identification")]
public partial record DocumentIdentification14
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    [IsoId("_ThCb09p-Ed-ak6NoX_4Aeg_-2132511197")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification1Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    [IsoId("_ThCb1Np-Ed-ak6NoX_4Aeg_1165383746")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public DocumentNumber1Choice_? DocumentNumber { get; init; } 
    
    
    #nullable disable
    
}
