// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a Stored Value service (Prepaid card or account).
/// </summary>
[IsoId("_o3XPQYYLEemxIqbaFEE8-w")]
[DisplayName("Stored Value Request")]
public partial record StoredValueRequest2
{
    #nullable enable
    
    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [IsoId("_pBy9oYYLEemxIqbaFEE8-w")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData2> Data { get; init; } = [];
    // ID for the above is _pBy9oYYLEemxIqbaFEE8-w
    
    
    #nullable disable
    
}
