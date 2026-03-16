// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional Information31.
/// </summary>
[IsoId("_AXqGIXNXEe6Y1uOeeiF_Eg")]
[DisplayName("Additional Information31")]
public partial record AdditionalInformation31
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public IsoMax350Text? AdditionalData { get; init; } 

    /// <summary>
    /// Alpha Numeric.
    /// </summary>
    [DisplayName("Alpha Numeric")]
    [IsoXmlTag("AlphaNmrc")]
    public IsoMax350Text? AlphaNumeric { get; init; } 

    /// <summary>
    /// Numeric.
    /// </summary>
    [DisplayName("Numeric")]
    [IsoXmlTag("Nmrc")]
    public IsoMax35NumericText? Numeric { get; init; } 

    
    #nullable disable
    
}
