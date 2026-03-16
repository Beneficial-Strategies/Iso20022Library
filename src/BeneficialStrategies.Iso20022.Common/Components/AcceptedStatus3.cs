// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Accepted Status3.
/// </summary>
[IsoId("_iCm9cZznEe-DHYbvdRjdbA")]
[DisplayName("Accepted Status3")]
public partial record AcceptedStatus3
{
    #nullable enable

    /// <summary>
    /// Accepted Quantity.
    /// </summary>
    [DisplayName("Accepted Quantity")]
    [IsoXmlTag("AccptdQty")]
    public Quantity54Choice_? AcceptedQuantity { get; init; } 

    /// <summary>
    /// Accepted Reason.
    /// </summary>
    [DisplayName("Accepted Reason")]
    [IsoXmlTag("AccptdRsn")]
    public required AcceptedStatus13Choice_ AcceptedReason { get; init; } 

    
    #nullable disable
    
}
