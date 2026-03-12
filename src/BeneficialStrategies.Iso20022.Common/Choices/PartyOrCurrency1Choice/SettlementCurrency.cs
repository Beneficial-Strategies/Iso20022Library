// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyOrCurrency1Choice
{
    /// <summary>
    /// Currency for the settlement.
    /// </summary>
    [IsoId("_n9oL79QiEeKvJeoOII0e7w")]
    [DisplayName("Settlement Currency")]
    public partial record SettlementCurrency : PartyOrCurrency1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A code allocated to a currency by a Maintenance Agency under an international identification scheme as described in the latest edition of the international standard ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
        /// </summary>
        [IsoXmlTag("SttlmCcy")]
        public required ActiveCurrencyCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
