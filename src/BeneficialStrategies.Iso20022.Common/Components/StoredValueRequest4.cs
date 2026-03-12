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
[IsoId("_zsqYsS84Eeu125Ip9zFcsQ")]
[DisplayName("Stored Value Request")]
public partial record StoredValueRequest4
{
    #nullable enable
    
    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [IsoId("_z5FrIS84Eeu125Ip9zFcsQ")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData4> Data { get; init; } = new ValueList<StoredValueData4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _z5FrIS84Eeu125Ip9zFcsQ
    
    
    #nullable disable
    
}
