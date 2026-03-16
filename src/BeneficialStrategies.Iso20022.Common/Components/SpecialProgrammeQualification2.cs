// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Special Programme Qualification2.
/// </summary>
[IsoId("_SeEdsZm-Ee6Qpd-x8YgzaA")]
[DisplayName("Special Programme Qualification2")]
public partial record SpecialProgrammeQualification2
{
    #nullable enable

    /// <summary>
    /// Detail.
    /// </summary>
    [DisplayName("Detail")]
    [IsoXmlTag("Dtl")]
    public ValueList<SpecialProgrammeDetails2> Detail { get; init; } = [];

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public IsoMax35Text? Programme { get; init; } 

    
    #nullable disable
    
}
