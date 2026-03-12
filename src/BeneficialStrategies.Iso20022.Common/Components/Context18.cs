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
[IsoId("_uGFQkTNIEeylu6lH-gut-A")]
[DisplayName("Context")]
public partial record Context18
{
    #nullable enable
    
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    [IsoId("_uNL-ITNIEeylu6lH-gut-A")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext3? PointOfServiceContext { get; init; } 
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_uNL-IzNIEeylu6lH-gut-A")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public TransactionContext7? TransactionContext { get; init; } 
    
    /// <summary>
    /// Contain validation result and/or data to be validated.
    /// </summary>
    [IsoId("_uNL-JTNIEeylu6lH-gut-A")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public Verification5? Verification { get; init; } 
    
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_uNL-JzNIEeylu6lH-gut-A")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext2? RiskContext { get; init; } 
    
    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_uNL-KTNIEeylu6lH-gut-A")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext8? SaleContext { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_6DFOETNIEeylu6lH-gut-A")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData2? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
