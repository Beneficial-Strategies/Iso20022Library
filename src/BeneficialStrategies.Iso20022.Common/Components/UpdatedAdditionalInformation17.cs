// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Updated Additional Information17.
/// </summary>
[IsoId("_cfd1EWHiEe6yt_d72zQZeQ")]
[DisplayName("Updated Additional Information17")]
public partial record UpdatedAdditionalInformation17
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax350Text> AdditionalInformation { get; init; } = [];

    
    #nullable disable
    
}
