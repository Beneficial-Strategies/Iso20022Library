// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResidenceLocation1Choice
{
    /// <summary>
    /// Specifies the account owner&apos;s resident country.
    /// </summary>
    [IsoId("_6Qsqk5qlEeGSON8vddiWzQ_-2009722376")]
    [DisplayName("Country")]
    public partial record Country : ResidenceLocation1Choice_
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
