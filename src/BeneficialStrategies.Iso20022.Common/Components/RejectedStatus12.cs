// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rejected Status12.
/// </summary>
[IsoId("_tOTPRZzmEe-DHYbvdRjdbA")]
[DisplayName("Rejected Status12")]
public partial record RejectedStatus12
{
    #nullable enable

    /// <summary>
    /// Rejected Quantity.
    /// </summary>
    [DisplayName("Rejected Quantity")]
    [IsoXmlTag("RjctdQty")]
    public Quantity54Choice_? RejectedQuantity { get; init; } 

    /// <summary>
    /// Rejected Reason.
    /// </summary>
    [DisplayName("Rejected Reason")]
    [IsoXmlTag("RjctdRsn")]
    public required RejectedStatus61Choice_ RejectedReason { get; init; } 

    
    #nullable disable
    
}
