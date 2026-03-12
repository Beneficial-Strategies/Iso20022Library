// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the document by providing a unique identification and optionally the date/time of the creation of the document.
/// </summary>
[IsoId("_RXNBiNp-Ed-ak6NoX_4Aeg_-320016249")]
[DisplayName("Document Identification")]
public partial record DocumentIdentification8
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the document.
    /// </summary>
    [IsoId("_RXNBidp-Ed-ak6NoX_4Aeg_-320016247")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date/time of the creation of the document.
    /// </summary>
    [IsoId("_RXNBitp-Ed-ak6NoX_4Aeg_-1412830128")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
