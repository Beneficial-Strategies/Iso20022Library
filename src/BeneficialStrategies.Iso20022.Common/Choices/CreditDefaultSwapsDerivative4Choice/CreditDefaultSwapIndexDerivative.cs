// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative4Choice
{
    /// <summary>
    /// A credit default swap derivative on an index.
    /// </summary>
    [IsoId("_xSzjVye0Eei12pGEsJIAeQ")]
    [DisplayName("Credit Default Swap Index Derivative")]
    public partial record CreditDefaultSwapIndexDerivative : CreditDefaultSwapsDerivative4Choice_
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
}
