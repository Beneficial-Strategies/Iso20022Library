// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification information expressed as a country of fiscal domicile and a reference.
/// </summary>
[IsoId("_rQA50MqREeWyL6686qMenw")]
[DisplayName("Generic Identification SD")]
public partial record GenericIdentificationSD1
{
    #nullable enable
    
    /// <summary>
    /// Country in which the account owner has one&apos;s fiscal domicile.
    /// </summary>
    [IsoId("_znnd8MqREeWyL6686qMenw")]
    [DisplayName("Fiscal Domicile")]
    [IsoXmlTag("FsclDmcl")]
    public required CountryCode FiscalDomicile { get; init; } 
    
    /// <summary>
    /// Identification of the document assigned by the account servicer.
    /// </summary>
    [IsoId("_ozw2CO0QEeWLj6RCdgRMog")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountServicerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the document assigned by the account owner.
    /// </summary>
    [IsoId("_ozw2DO0QEeWLj6RCdgRMog")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerIdentification { get; init; } 
    
    
    #nullable disable
    
}
