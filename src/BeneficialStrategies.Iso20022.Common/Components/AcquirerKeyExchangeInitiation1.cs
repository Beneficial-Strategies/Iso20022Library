// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the key exchange.
/// </summary>
[IsoId("_E98w4HvHEeSCJdwgzb6SFw")]
[DisplayName("Acquirer Key Exchange Initiation")]
public partial record AcquirerKeyExchangeInitiation1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Qe3PUHvHEeSCJdwgzb6SFw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment6 Environment { get; init; } 
    
    /// <summary>
    /// Key exchange transaction.
    /// </summary>
    [IsoId("_bm2QYHvHEeSCJdwgzb6SFw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction13 Transaction { get; init; } 
    
    
    #nullable disable
    
}
