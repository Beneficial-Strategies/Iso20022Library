// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reversal.
/// </summary>
[IsoId("_pW3FoHuxEeS2Z_kGi7H1VQ")]
[DisplayName("Acquirer Reversal Initiation")]
public partial record AcquirerReversalInitiation1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_GiVhUHuyEeS2Z_kGi7H1VQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment3 Environment { get; init; } 
    
    /// <summary>
    /// Reversal transaction.
    /// </summary>
    [IsoId("_X6YgUHu0EeS2Z_kGi7H1VQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction7 Transaction { get; init; } 
    
    
    #nullable disable
    
}
