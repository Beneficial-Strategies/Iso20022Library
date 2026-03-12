// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification1Choice
{
    /// <summary>
    /// Country in which the transaction is executed.
    /// </summary>
    [IsoId("_TCfeoNp-Ed-ak6NoX_4Aeg_-1351023386")]
    [DisplayName("Country")]
    public partial record Country : PlaceOfTradeIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [IsoXmlTag("Ctry")]
        public required CountryCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
