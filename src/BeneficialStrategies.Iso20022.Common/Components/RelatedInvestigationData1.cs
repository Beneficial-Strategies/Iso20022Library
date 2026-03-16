// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Related Investigation Data1.
/// </summary>
[IsoId("_CXmpUFRtEe23M4WgERMsYw")]
[DisplayName("Related Investigation Data1")]
public partial record RelatedInvestigationData1
{
    #nullable enable

    /// <summary>
    /// Investigation Identification.
    /// </summary>
    [DisplayName("Investigation Identification")]
    [IsoXmlTag("InvstgtnId")]
    public IsoMax35Text? InvestigationIdentification { get; init; } 

    /// <summary>
    /// Location.
    /// </summary>
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public ValueList<InvestigationLocationData1> Location { get; init; } = [];

    
    #nullable disable
    
}
