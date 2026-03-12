// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the document line identification.
/// </summary>
[IsoId("_cX4kMablEeKvUvwX_r3tzA")]
[DisplayName("Document Line Type")]
public partial record DocumentLineType1
{
    #nullable enable
    
    /// <summary>
    /// Provides the type details of the referred document line identification.
    /// </summary>
    [IsoId("_ciKhlablEeKvUvwX_r3tzA")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required DocumentLineType1Choice_ CodeOrProprietary { get; init; } 
    
    /// <summary>
    /// Identification of the issuer of the reference document line identificationtype.
    /// </summary>
    [IsoId("_ciKhmablEeKvUvwX_r3tzA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    
    #nullable disable
    
}
