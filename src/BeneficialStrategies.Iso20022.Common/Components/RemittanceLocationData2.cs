// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Location Data2.
/// </summary>
[IsoId("_0KjnBTEyEe6g-ffJsqGiSA")]
[DisplayName("Remittance Location Data2")]
public partial record RemittanceLocationData2
{
    #nullable enable

    /// <summary>
    /// Electronic Address.
    /// </summary>
    [DisplayName("Electronic Address")]
    [IsoXmlTag("ElctrncAdr")]
    public IsoMax2048Text? ElectronicAddress { get; init; } 

    /// <summary>
    /// Method.
    /// </summary>
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required RemittanceLocationMethod2Code Method { get; init; } 

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public NameAndAddress18? PostalAddress { get; init; } 

    
    #nullable disable
    
}
