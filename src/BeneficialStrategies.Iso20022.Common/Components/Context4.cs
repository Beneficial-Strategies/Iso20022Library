// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
[IsoId("_IRz0cVZpEeeFltjJxERUxw")]
[DisplayName("Context")]
public partial record Context4
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_IDx3gewHEeiMkKo2clXHdQ")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext2? PointOfServiceContext { get; init; } 
    
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_bU7OIFZrEeeFltjJxERUxw")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext3 TransactionContext { get; init; } 
    
    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_IdQ2iVZpEeeFltjJxERUxw")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext7? SaleContext { get; init; } 
    
    
    #nullable disable
    
}
