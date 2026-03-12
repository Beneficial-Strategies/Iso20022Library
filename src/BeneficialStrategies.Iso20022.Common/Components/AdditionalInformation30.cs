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
[IsoId("_YK_0gUJKEeycgPMNjuGITQ")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation30
{
    #nullable enable
    
    /// <summary>
    /// Recipient of the additional information to display, print, send or store.
    /// </summary>
    [IsoId("_YPONMUJKEeycgPMNjuGITQ")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public PartyType19Code? Recipient { get; init; } 
    
    /// <summary>
    /// Target of the additional information to print, display, send or store.
    /// </summary>
    [IsoId("_YPONM0JKEeycgPMNjuGITQ")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public UserInterface8Code? Target { get; init; } 
    
    /// <summary>
    /// Format of the additional information.
    /// </summary>
    [IsoId("_YPONNUJKEeycgPMNjuGITQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; } 
    
    /// <summary>
    /// Defines the type of the value.
    /// </summary>
    [IsoId("_YPONN0JKEeycgPMNjuGITQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_bzMDMUJKEeycgPMNjuGITQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; } 
    
    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_YPONOUJKEeycgPMNjuGITQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20KText Value { get; init; } 
    
    
    #nullable disable
    
}
