// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Report information for one transaction.
/// </summary>
[IsoId("_li9A4N6WEeiwsev40qZGEQ")]
[DisplayName("Point Of Interaction Transaction Report")]
public partial record PointOfInteractionTransactionReport1
{
    #nullable enable
    
    /// <summary>
    /// Response for this specific transaction.
    /// </summary>
    [IsoId("_r5azsN6WEeiwsev40qZGEQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; } 
    
    /// <summary>
    /// Data responded to a Payment request.
    /// </summary>
    [IsoId("_6DVUsN6WEeiwsev40qZGEQ")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse1? PaymentResponse { get; init; } 
    
    
    #nullable disable
    
}
