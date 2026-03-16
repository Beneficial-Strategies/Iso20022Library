// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Programme Mode5.
/// </summary>
[IsoId("_QlWS8XjMEe6YlIMyoxWMJA")]
[DisplayName("Programme Mode5")]
public partial record ProgrammeMode5
{
    #nullable enable

    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<AdditionalData1> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Applied Identification.
    /// </summary>
    [DisplayName("Applied Identification")]
    [IsoXmlTag("ApldId")]
    public required IsoMax35Text AppliedIdentification { get; init; } 

    
    #nullable disable
    
}
