// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restriction on capability or operations allowed.
/// </summary>
[IsoId("_PUhYHtp-Ed-ak6NoX_4Aeg_-335182924")]
[DisplayName("Restriction")]
public partial record Restriction1
{
    #nullable enable
    
    /// <summary>
    /// Type of the restriction.
    /// </summary>
    [IsoId("_PUhYH9p-Ed-ak6NoX_4Aeg_1543244557")]
    [DisplayName("Restriction Type")]
    [IsoXmlTag("RstrctnTp")]
    public required CodeOrProprietary1Choice_ RestrictionType { get; init; } 
    
    /// <summary>
    /// Date from when the restriction is valid.
    /// </summary>
    [IsoId("_PUhYINp-Ed-ak6NoX_4Aeg_736440027")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ValidFrom { get; init; } 
    
    /// <summary>
    /// Date until when the restriction is valid.
    /// </summary>
    [IsoId("_PUrJENp-Ed-ak6NoX_4Aeg_1733310129")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValidUntil { get; init; } 
    
    
    #nullable disable
    
}
