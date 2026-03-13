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
[IsoId("_7tZNMQxqEeqdx6buGpCCQw")]
[DisplayName("Stored Value Request")]
public partial record StoredValueRequest3
{
    #nullable enable
    
    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [IsoId("_74xWwQxqEeqdx6buGpCCQw")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData3> Data { get; init; } = [];
    // ID for the above is _74xWwQxqEeqdx6buGpCCQw
    
    
    #nullable disable
    
}
