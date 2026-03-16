// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification276.
/// </summary>
[IsoId("_xHwJLVx7Ee6fgZt44_IqFA")]
[DisplayName("Party Identification276")]
public partial record PartyIdentification276
{
    #nullable enable

    /// <summary>
    /// Legal Person.
    /// </summary>
    [DisplayName("Legal Person")]
    [IsoXmlTag("LglPrsn")]
    public ValueList<PartyIdentification275> LegalPerson { get; init; } = [];

    /// <summary>
    /// Natural Person.
    /// </summary>
    [DisplayName("Natural Person")]
    [IsoXmlTag("NtrlPrsn")]
    public ValueList<PartyIdentification217> NaturalPerson { get; init; } = [];

    
    #nullable disable
    
}
