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
[IsoId("_hLG7EQ1LEeqjM-rxn3HuXQ")]
[DisplayName("Point Of Interaction Transaction Report")]
public partial record PointOfInteractionTransactionReport2
{
    #nullable enable
    
    /// <summary>
    /// Response for this specific transaction.
    /// </summary>
    [IsoId("_hWcBUQ1LEeqjM-rxn3HuXQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; } 
    
    /// <summary>
    /// Data responded to a Payment request.
    /// </summary>
    [IsoId("_hWcBUw1LEeqjM-rxn3HuXQ")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse2? PaymentResponse { get; init; } 
    
    
    #nullable disable
    
}
