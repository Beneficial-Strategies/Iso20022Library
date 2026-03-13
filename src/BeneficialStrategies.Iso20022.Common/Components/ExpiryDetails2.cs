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
[IsoId("_5uOnIoAAEeGOn4dfTT_QdQ")]
[DisplayName("Expiry Details")]
public partial record ExpiryDetails2
{
    #nullable enable
    
    /// <summary>
    /// Terms defining when the undertaking will cease to be available.
    /// </summary>
    [IsoId("_5uOnKIAAEeGOn4dfTT_QdQ")]
    [DisplayName("Expiry Terms")]
    [IsoXmlTag("XpryTerms")]
    public ExpiryTerms2? ExpiryTerms { get; init; } 
    
    /// <summary>
    /// Additional information related to the expiry and expiry extension.
    /// </summary>
    [IsoId("_5uOnJYAAEeGOn4dfTT_QdQ")]
    [DisplayName("Additional Expiry Information")]
    [IsoXmlTag("AddtlXpryInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalExpiryInformation { get; init; } = [];
    
    
    #nullable disable
    
}
