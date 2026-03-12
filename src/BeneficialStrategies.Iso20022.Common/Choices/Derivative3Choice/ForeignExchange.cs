// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice
{
    /// <summary>
    /// Details specific for Foreign exchange.
    /// </summary>
    [IsoId("_xH-zZSe0Eei12pGEsJIAeQ")]
    [DisplayName("Foreign Exchange")]
    public partial record ForeignExchange : Derivative3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of deliverable and non-deliverable forwards, options and swaps contract.	.
        /// </summary>
        [IsoId("_UA7JoX5iEeaGiOUFl5b1oQ")]
        [DisplayName("Contract Sub Type")]
        [IsoXmlTag("CtrctSubTp")]
        public required AssetClassSubProductType19Code ContractSubType { get; init; } 
        
        
        #nullable disable
        
    }
}
