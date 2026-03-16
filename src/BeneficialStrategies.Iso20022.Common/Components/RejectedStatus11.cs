// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rejected Status11.
/// </summary>
[IsoId("__DbpoYWAEe-ufOxNNkEXmg")]
[DisplayName("Rejected Status11")]
public partial record RejectedStatus11
{
    #nullable enable

    /// <summary>
    /// Rejected Quantity.
    /// </summary>
    [DisplayName("Rejected Quantity")]
    [IsoXmlTag("RjctdQty")]
    public Quantity51Choice_? RejectedQuantity { get; init; } 

    /// <summary>
    /// Rejected Reason.
    /// </summary>
    [DisplayName("Rejected Reason")]
    [IsoXmlTag("RjctdRsn")]
    public required RejectedStatus56Choice_ RejectedReason { get; init; } 

    
    #nullable disable
    
}
