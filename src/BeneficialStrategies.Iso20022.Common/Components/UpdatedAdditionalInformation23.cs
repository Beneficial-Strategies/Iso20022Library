// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Updated Additional Information23.
/// </summary>
[IsoId("_U1azB3SdEe6VWZz2tTgENw")]
[DisplayName("Updated Additional Information23")]
public partial record UpdatedAdditionalInformation23
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoRestrictedFINXMax350Text> AdditionalInformation { get; init; } = [];

    
    #nullable disable
    
}
