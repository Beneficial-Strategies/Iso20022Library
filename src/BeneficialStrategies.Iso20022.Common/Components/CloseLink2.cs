// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the close links as defined in the collateral reference data.
/// </summary>
[IsoId("_WBMWAeLXEeWFtOV72FbX9w")]
[DisplayName("Close Link")]
public partial record CloseLink2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_WMpYEeLXEeWFtOV72FbX9w")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the party for which the close link is defined.
    /// </summary>
    [IsoId("_WMpYE-LXEeWFtOV72FbX9w")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification1Choice_ PartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
