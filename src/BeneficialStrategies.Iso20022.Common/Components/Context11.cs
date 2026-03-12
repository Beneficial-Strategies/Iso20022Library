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
[IsoId("_SZeAkYN1EeuHqfO1LgkE9Q")]
[DisplayName("Context")]
public partial record Context11
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_SeCXgYN1EeuHqfO1LgkE9Q")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public required PointOfServiceContext3 PointOfServiceContext { get; init; } 
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_SeCXg4N1EeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext7 TransactionContext { get; init; } 
    
    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify the cardholder or his card.
    /// </summary>
    [IsoId("_SeCXhYN1EeuHqfO1LgkE9Q")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public Verification5? Verification { get; init; } 
    
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_SeCXh4N1EeuHqfO1LgkE9Q")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext2? RiskContext { get; init; } 
    
    
    #nullable disable
    
}
