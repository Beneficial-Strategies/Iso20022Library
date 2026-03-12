// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information relevant to the destination.
/// </summary>
[IsoId("_kIe6gVBBEeedyPuM0kK2EQ")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation21
{
    #nullable enable
    
    /// <summary>
    /// Recipient of the additional information to display, print, send or store.
    /// </summary>
    [IsoId("_kTMVsVBBEeedyPuM0kK2EQ")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public PartyType23Code? Recipient { get; init; } 
    
    /// <summary>
    /// Target of the additional information to print, display, send or store.
    /// </summary>
    [IsoId("_kTMVs1BBEeedyPuM0kK2EQ")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public UserInterface7Code? Target { get; init; } 
    
    /// <summary>
    /// Format of the additional information.
    /// </summary>
    [IsoId("_kTMVtVBBEeedyPuM0kK2EQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; } 
    
    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_uUVFsewlEeiMkKo2clXHdQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20KText Value { get; init; } 
    
    
    #nullable disable
    
}
