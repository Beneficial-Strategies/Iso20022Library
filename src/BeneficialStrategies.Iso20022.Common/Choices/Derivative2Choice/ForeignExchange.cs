// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice
{
    /// <summary>
    /// Details specific for Foreign exchange.
    /// </summary>
    [IsoId("_Bv9MRWkwEeaLAKoEUNsD9g")]
    [DisplayName("Foreign Exchange")]
    public record ForeignExchange : Derivative2Choice_
    {
        /// <summary>
        /// Type of deliverable and non-deliverable forwards, options and swaps contract.	.
        /// </summary>
        [IsoId("_UA7JoX5iEeaGiOUFl5b1oQ")]
        [DisplayName("Contract Sub Type")]
        [IsoXmlTag("CtrctSubTp")]
        public required AssetClassSubProductType19Code ContractSubType { get; init; }
    }
}
