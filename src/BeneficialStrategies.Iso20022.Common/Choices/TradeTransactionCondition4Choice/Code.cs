// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionCondition4Choice
{
    /// <summary>
    /// Trade conditions expressed in a coded form as published in an external list.
    /// </summary>
    [IsoId("_AcingNokEeC60axPepSq7g_-1258318149")]
    [DisplayName("Code")]
    public partial record Code : TradeTransactionCondition4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTradeTransactionCondition1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
