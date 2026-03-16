// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Location Data1.
/// </summary>
[IsoId("_CXmpVFRtEe23M4WgERMsYw")]
[DisplayName("Investigation Location Data1")]
public partial record InvestigationLocationData1
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
    public required InvestigationLocationMethod1Code Method { get; init; } 

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public NameAndAddress16? PostalAddress { get; init; } 

    
    #nullable disable
    
}
