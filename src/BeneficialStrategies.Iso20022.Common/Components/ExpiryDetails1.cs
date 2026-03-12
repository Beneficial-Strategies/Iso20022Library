// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Expiry and extension information.
/// </summary>
[IsoId("_95ylYnltEeG7BsjMvd1mEw_522259600")]
[DisplayName("Expiry Details")]
public partial record ExpiryDetails1
{
    #nullable enable
    
    /// <summary>
    /// Terms defining when the undertaking will cease to be available.
    /// </summary>
    [IsoId("_95ylY3ltEeG7BsjMvd1mEw_524791054")]
    [DisplayName("Expiry Terms")]
    [IsoXmlTag("XpryTerms")]
    public ExpiryTerms1? ExpiryTerms { get; init; } 
    
    /// <summary>
    /// Additional information related to the expiry and expiry extension.
    /// </summary>
    [IsoId("_95ylZHltEeG7BsjMvd1mEw_807326338")]
    [DisplayName("Additional Expiry Information")]
    [IsoXmlTag("AddtlXpryInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalExpiryInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
