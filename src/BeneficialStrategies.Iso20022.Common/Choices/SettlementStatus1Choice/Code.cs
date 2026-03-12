// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus1Choice
{
    /// <summary>
    /// Provides the status of settlement of an instruction/financial instrument movement.
    /// </summary>
    [IsoId("_UYeaINp-Ed-ak6NoX_4Aeg_-484322999")]
    [DisplayName("Code")]
    public partial record Code : SettlementStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the status of settlement of an instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesSettlementStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
