// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlingCapacity1Choice
{
    /// <summary>
    /// Settlement capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QwK2s9p-Ed-ak6NoX_4Aeg_61454778")]
    [DisplayName("Code")]
    public partial record Code : SettlingCapacity1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the party in the settlement of the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlingCapacity1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
