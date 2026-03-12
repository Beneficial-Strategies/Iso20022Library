// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the document referred in the remittance information.
/// </summary>
[IsoId("_Xf7GCR77EeSxevWRRWxNAg")]
[DisplayName("Referred Document Type")]
public partial record ReferredDocumentType4
{
    #nullable enable
    
    /// <summary>
    /// Provides the type details of the referred document.
    /// </summary>
    [IsoId("_XxL1Ix77EeSxevWRRWxNAg")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required ReferredDocumentType3Choice_ CodeOrProprietary { get; init; } 
    
    /// <summary>
    /// Identification of the issuer of the reference document type.
    /// </summary>
    [IsoId("_XxL1JR77EeSxevWRRWxNAg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
