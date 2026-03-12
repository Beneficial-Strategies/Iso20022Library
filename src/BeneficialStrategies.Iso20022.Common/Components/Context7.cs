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
[IsoId("_LBwzgUP-EeiFlYmBVFSxUw")]
[DisplayName("Context")]
public partial record Context7
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_LN9ccUP-EeiFlYmBVFSxUw")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext2? PointOfServiceContext { get; init; } 
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_LN9cc0P-EeiFlYmBVFSxUw")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public TransactionContext4? TransactionContext { get; init; } 
    
    
    #nullable disable
    
}
