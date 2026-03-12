// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a payment instruction by its relative position in a queue of payment transactions managed by the clearing agent.
/// </summary>
[IsoId("_X0ioAZlQEee-Zps0fZQaFQ")]
[DisplayName("Queue Transaction Identification")]
public partial record QueueTransactionIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the payment queue where the payment instruction resides.
    /// </summary>
    [IsoId("_X8kioZlQEee-Zps0fZQaFQ")]
    [DisplayName("Queue Identification")]
    [IsoXmlTag("QId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text QueueIdentification { get; init; } 
    
    /// <summary>
    /// Position of the payment instruction within the identified queue.
    /// </summary>
    [IsoId("_X8kio5lQEee-Zps0fZQaFQ")]
    [DisplayName("Position In Queue")]
    [IsoXmlTag("PosInQ")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text PositionInQueue { get; init; } 
    
    
    #nullable disable
    
}
