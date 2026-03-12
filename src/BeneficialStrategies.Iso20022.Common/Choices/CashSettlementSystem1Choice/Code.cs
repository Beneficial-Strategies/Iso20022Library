// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystem1Choice
{
    /// <summary>
    /// Cash settlement system expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qv3UuNp-Ed-ak6NoX_4Aeg_-882993888")]
    [DisplayName("Code")]
    public partial record Code : CashSettlementSystem1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the cash settlement system used.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CashSettlementSystem2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
