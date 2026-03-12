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
[IsoId("_n7eS8EXYEeegp_DADCe7HQ")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation20
{
    #nullable enable
    
    /// <summary>
    /// Recipient of the additional information to display, print, send or store.
    /// </summary>
    [IsoId("_728i4EXYEeegp_DADCe7HQ")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public PartyType22Code? Recipient { get; init; } 
    
    /// <summary>
    /// Other type of recipient of action data.
    /// </summary>
    [IsoId("_2IAAoFKdEeeFcfYfFkVztg")]
    [DisplayName("Other Recipient")]
    [IsoXmlTag("OthrRcpt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherRecipient { get; init; } 
    
    /// <summary>
    /// Target of the additional information to print, display, send or store.
    /// </summary>
    [IsoId("_CbEXMEXZEeegp_DADCe7HQ")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public UserInterface6Code? Target { get; init; } 
    
    /// <summary>
    /// Other type of target for action data.
    /// </summary>
    [IsoId("_8Jnk0FKdEeeFcfYfFkVztg")]
    [DisplayName("Other Target")]
    [IsoXmlTag("OthrTrgt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherTarget { get; init; } 
    
    /// <summary>
    /// Format of the additional information.
    /// </summary>
    [IsoId("_KjaXUEXZEeegp_DADCe7HQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; } 
    
    /// <summary>
    /// Other output format.
    /// </summary>
    [IsoId("_CEF_MFKeEeeFcfYfFkVztg")]
    [DisplayName("Other Format")]
    [IsoXmlTag("OthrFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherFormat { get; init; } 
    
    /// <summary>
    /// Defines the type of the value.
    /// </summary>
    [IsoId("_RGBF4Bs4EeqrvK3udMUsNQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_vuWMoewlEeiMkKo2clXHdQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20KText Value { get; init; } 
    
    
    #nullable disable
    
}
