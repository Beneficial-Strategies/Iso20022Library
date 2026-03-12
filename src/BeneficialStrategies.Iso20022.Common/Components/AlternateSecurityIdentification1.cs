// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary or domestic identification scheme that uniquely identifies a security.
/// </summary>
[IsoId("_Sk_qX9p-Ed-ak6NoX_4Aeg_-815168274")]
[DisplayName("Alternate Security Identification")]
public partial record AlternateSecurityIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_Sk_qYNp-Ed-ak6NoX_4Aeg_-815168262")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    [IsoId("_Sk_qYdp-Ed-ak6NoX_4Aeg_-815168264")]
    [DisplayName("Domestic Identification Source")]
    [IsoXmlTag("DmstIdSrc")]
    public required CountryCode DomesticIdentificationSource { get; init; } 
    
    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    [IsoId("_Sk_qYtp-Ed-ak6NoX_4Aeg_-815168263")]
    [DisplayName("Proprietary Identification Source")]
    [IsoXmlTag("PrtryIdSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ProprietaryIdentificationSource { get; init; } 
    
    
    #nullable disable
    
}
