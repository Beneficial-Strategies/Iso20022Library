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
[IsoId("_qbx_gYN0EeuHqfO1LgkE9Q")]
[DisplayName("Context")]
public partial record Context10
{
    #nullable enable
    
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    [IsoId("_qgLXUYN0EeuHqfO1LgkE9Q")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public required PointOfServiceContext3 PointOfServiceContext { get; init; } 
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_qgLXU4N0EeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext7 TransactionContext { get; init; } 
    
    /// <summary>
    /// Contain validation result and/or data to be validated.
    /// </summary>
    [IsoId("_qgLXVYN0EeuHqfO1LgkE9Q")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public Verification5? Verification { get; init; } 
    
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_qgLXV4N0EeuHqfO1LgkE9Q")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext2? RiskContext { get; init; } 
    
    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_qgLXWYN0EeuHqfO1LgkE9Q")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext8? SaleContext { get; init; } 
    
    
    #nullable disable
    
}
