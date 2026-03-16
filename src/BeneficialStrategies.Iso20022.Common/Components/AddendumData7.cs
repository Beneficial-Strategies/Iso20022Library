// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum Data7.
/// </summary>
[IsoId("_RnF4QXjWEe6YlIMyoxWMJA")]
[DisplayName("Addendum Data7")]
public partial record AddendumData7
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData2> AdditionalData { get; init; } = [];

    /// <summary>
    /// Fleet Line Item.
    /// </summary>
    [DisplayName("Fleet Line Item")]
    [IsoXmlTag("FleetLineItm")]
    public ValueList<FleetLineItem6> FleetLineItem { get; init; } = [];

    
    #nullable disable
    
}
