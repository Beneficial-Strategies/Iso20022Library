// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceType6Choice
{
    /// <summary>
    /// Balance type expressed in coded form.
    /// </summary>
    [IsoId("_nArEUvNBEeCuA5Tr22BnwA_-353374082")]
    [DisplayName("Code")]
    public partial record Code : BalanceType6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the kind of the balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType13Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
