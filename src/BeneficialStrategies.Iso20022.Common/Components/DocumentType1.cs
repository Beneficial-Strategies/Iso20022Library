// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document Type1.
/// </summary>
[IsoId("_O2EK4TE0Ee62xuUQ2zyZww")]
[DisplayName("Document Type1")]
public partial record DocumentType1
{
    #nullable enable

    /// <summary>
    /// Code Or Proprietary.
    /// </summary>
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required DocumentType2Choice_ CodeOrProprietary { get; init; } 

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; } 

    
    #nullable disable
    
}
