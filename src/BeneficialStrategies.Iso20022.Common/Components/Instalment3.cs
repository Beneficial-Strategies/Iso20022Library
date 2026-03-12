// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
/// </summary>
[IsoId("_NTS84EVIEeea-M6VZkEPUw")]
[DisplayName("Instalment")]
public partial record Instalment3
{
    #nullable enable
    
    /// <summary>
    /// Indicates the occurrence of a single instalment payment within a series of instalment payments. 
    /// </summary>
    [IsoId("_4paSUEVIEeea-M6VZkEPUw")]
    [DisplayName("Payment Sequence Number")]
    [IsoXmlTag("PmtSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PaymentSequenceNumber { get; init; } 
    
    /// <summary>
    /// Attributes of the instalment plan.
    /// </summary>
    [IsoId("_9Lq8kEVIEeea-M6VZkEPUw")]
    [DisplayName("Plan")]
    [IsoXmlTag("Plan")]
    public Plan1? Plan { get; init; } 
    
    
    #nullable disable
    
}
