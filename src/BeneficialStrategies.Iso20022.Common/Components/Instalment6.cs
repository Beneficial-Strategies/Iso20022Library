// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instalment6.
/// </summary>
[IsoId("_G2Xe0XG-Ee60F8I8TAMKmg")]
[DisplayName("Instalment6")]
public partial record Instalment6
{
    #nullable enable

    /// <summary>
    /// Payment Sequence Number.
    /// </summary>
    [DisplayName("Payment Sequence Number")]
    [IsoXmlTag("PmtSeqNb")]
    public IsoNumber? PaymentSequenceNumber { get; init; } 

    /// <summary>
    /// Plan.
    /// </summary>
    [DisplayName("Plan")]
    [IsoXmlTag("Plan")]
    public ValueList<Plan3> Plan { get; init; } = [];

    
    #nullable disable
    
}
