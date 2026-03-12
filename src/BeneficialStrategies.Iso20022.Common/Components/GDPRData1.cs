// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an individual&apos;s consent to use personal data under the General Protection Regulation (GDPR) 2016/679 regulation.
/// </summary>
[IsoId("_7r9TsJTSEemC09f0MxYkRg")]
[DisplayName("GDPR Data")]
public partial record GDPRData1
{
    #nullable enable
    
    /// <summary>
    /// Type of consent.
    /// </summary>
    [IsoId("_BaPFIJTTEemC09f0MxYkRg")]
    [DisplayName("Consent Type")]
    [IsoXmlTag("CnsntTp")]
    public required GDPRDataConsent1Choice_ ConsentType { get; init; } 
    
    /// <summary>
    /// Indicates whether consent has been given.
    /// </summary>
    [IsoId("_6seTAJTaEemC09f0MxYkRg")]
    [DisplayName("Consent Indicator")]
    [IsoXmlTag("CnsntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ConsentIndicator { get; init; } 
    
    /// <summary>
    /// Date of the consent.
    /// </summary>
    [IsoId("_-uSioJTaEemC09f0MxYkRg")]
    [DisplayName("Consent Date")]
    [IsoXmlTag("CnsntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ConsentDate { get; init; } 
    
    
    #nullable disable
    
}
