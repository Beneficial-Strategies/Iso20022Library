// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creditor Reference Type3.
/// </summary>
[IsoId("_7xH-hTEsEe6GxLzpkVnWYg")]
[DisplayName("Creditor Reference Type3")]
public partial record CreditorReferenceType3
{
    #nullable enable

    /// <summary>
    /// Code Or Proprietary.
    /// </summary>
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required CreditorReferenceType2Choice_ CodeOrProprietary { get; init; } 

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; } 

    
    #nullable disable
    
}
