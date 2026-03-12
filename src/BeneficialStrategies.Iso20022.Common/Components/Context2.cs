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
[IsoId("_jTOIgU9nEeePXdaAO32Uew")]
[DisplayName("Context")]
public partial record Context2
{
    #nullable enable
    
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    [IsoId("_LW7KcRqbEeqH1IQNpbVpEw")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext1? PointOfServiceContext { get; init; } 
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_jeFUs09nEeePXdaAO32Uew")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public TransactionContext3? TransactionContext { get; init; } 
    
    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify  the cardholder or his card.
    /// </summary>
    [IsoId("_jeFUtU9nEeePXdaAO32Uew")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public Verification2? Verification { get; init; } 
    
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_jeFUt09nEeePXdaAO32Uew")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext1? RiskContext { get; init; } 
    
    
    #nullable disable
    
}
