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
[IsoId("_y9nX8VDfEee94_dUz-hvgw")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation22
{
    #nullable enable
    
    /// <summary>
    /// Recipient of the additional information to display, print, send or store.
    /// </summary>
    [IsoId("_zI7QEVDfEee94_dUz-hvgw")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public PartyType19Code? Recipient { get; init; } 
    
    /// <summary>
    /// Target of the additional information to print, display, send or store.
    /// </summary>
    [IsoId("_zI7QE1DfEee94_dUz-hvgw")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public UserInterface8Code? Target { get; init; } 
    
    /// <summary>
    /// Format of the additional information.
    /// </summary>
    [IsoId("_zI7QFVDfEee94_dUz-hvgw")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; } 
    
    /// <summary>
    /// Defines the type of the value.
    /// </summary>
    [IsoId("_XYwPQRs4EeqrvK3udMUsNQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_zI7QF1DfEee94_dUz-hvgw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20KText Value { get; init; } 
    
    
    #nullable disable
    
}
