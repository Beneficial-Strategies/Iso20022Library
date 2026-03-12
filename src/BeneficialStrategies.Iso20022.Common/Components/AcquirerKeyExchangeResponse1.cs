// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to a key exchange.
/// </summary>
[IsoId("_HDOPwHvREeS2PZh7wUMQog")]
[DisplayName("Acquirer Key Exchange Response")]
public partial record AcquirerKeyExchangeResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_TiiQIHvREeS2PZh7wUMQog")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment6 Environment { get; init; } 
    
    /// <summary>
    /// Key exchange transaction.
    /// </summary>
    [IsoId("_tKLYsHvREeS2PZh7wUMQog")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction14 Transaction { get; init; } 
    
    
    #nullable disable
    
}
