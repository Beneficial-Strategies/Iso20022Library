// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Generic identification scheme for a document.
/// </summary>
[IsoId("_QtVlJNp-Ed-ak6NoX_4Aeg_2133317488")]
[DisplayName("Generic Document Identification")]
public partial record GenericDocumentIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_QtVlJdp-Ed-ak6NoX_4Aeg_-2104392897")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Identification of the document.
    /// </summary>
    [IsoId("_QtVlJtp-Ed-ak6NoX_4Aeg_981420472")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    
    #nullable disable
    
}
