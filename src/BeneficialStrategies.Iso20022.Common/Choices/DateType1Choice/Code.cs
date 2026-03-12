// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateType1Choice
{
    /// <summary>
    /// Date identified using a code.
    /// </summary>
    [IsoId("_Q-6dVNp-Ed-ak6NoX_4Aeg_1998212837")]
    [DisplayName("Code")]
    public partial record Code : DateType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the date of settlement in coded form.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementDate2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
