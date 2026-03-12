// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit default swap derivative specific for reporting derivatives on a credit default swap index.
/// </summary>
[IsoId("_xS0KYSe0Eei12pGEsJIAeQ")]
[DisplayName("Credit Default Swap Derivative")]
public partial record CreditDefaultSwapDerivative5
{
    #nullable enable
    
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying swap.
    /// </summary>
    [IsoId("__ZOEYie0Eei12pGEsJIAeQ")]
    [DisplayName("Underlying Credit Default Swap Identification")]
    [IsoXmlTag("UndrlygCdtDfltSwpId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? UnderlyingCreditDefaultSwapIdentification { get; init; } 
    
    /// <summary>
    /// Describes the Credit Default Swap Index specific details the derivative is being made on.
    /// </summary>
    [IsoId("_xczM1Se0Eei12pGEsJIAeQ")]
    [DisplayName("Underlying Credit Default Swap Index")]
    [IsoXmlTag("UndrlygCdtDfltSwpIndx")]
    public required CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
    
    
    #nullable disable
    
}
