// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an authorisation.
/// </summary>
[IsoId("__-xbkHuOEeSVeNXcmBQ4hQ")]
[DisplayName("Acquirer Authorisation Response")]
public partial record AcquirerAuthorisationResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_0-HVEHuPEeSVeNXcmBQ4hQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment2 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_616z4IO8EeSWSLYdc10LRg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardTransactionContext3? Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which the authorisation has been requested.
    /// </summary>
    [IsoId("_06WvEHuSEeSVeNXcmBQ4hQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardTransaction4? Transaction { get; init; } 
    
    
    #nullable disable
    
}
