// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restrictions applicable to the security.
/// </summary>
[IsoId("_cW1DkeLxEeWOD7aAy2fAcA")]
[DisplayName("Security Restriction")]
public partial record SecurityRestriction2
{
    #nullable enable
    
    /// <summary>
    /// Period during which the restriction applies.
    /// </summary>
    [IsoId("_cg8o4eLxEeWOD7aAy2fAcA")]
    [DisplayName("Effective Period")]
    [IsoXmlTag("FctvPrd")]
    public DateTimePeriodDetails1? EffectivePeriod { get; init; } 
    
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    [IsoId("_cg8o4-LxEeWOD7aAy2fAcA")]
    [DisplayName("Restriction Type")]
    [IsoXmlTag("RstrctnTp")]
    public SecurityRestrictionType2Choice_? RestrictionType { get; init; } 
    
    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_cg8o5eLxEeWOD7aAy2fAcA")]
    [DisplayName("Legal Restriction Type")]
    [IsoXmlTag("LglRstrctnTp")]
    public LegalRestrictions5Choice_? LegalRestrictionType { get; init; } 
    
    /// <summary>
    /// Specifies whether the restriction to be applied is relevant for citizen, resident, country.
    /// </summary>
    [IsoId("_cg8o5-LxEeWOD7aAy2fAcA")]
    [DisplayName("Investor Restriction Type")]
    [IsoXmlTag("InvstrRstrctnTp")]
    public InvestorRestrictionType3Choice_? InvestorRestrictionType { get; init; } 
    
    /// <summary>
    /// Type of investor that is allowed to hold the security.
    /// </summary>
    [IsoId("_cg8o6eLxEeWOD7aAy2fAcA")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType3Choice_? InvestorType { get; init; } 
    
    
    #nullable disable
    
}
