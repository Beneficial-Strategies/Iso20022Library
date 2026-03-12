// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BookingUnit1Choice
{
    /// <summary>
    /// Booking unit is defined using a code.
    /// </summary>
    [IsoId("_Q-6dV9p-Ed-ak6NoX_4Aeg_1747410381")]
    [DisplayName("Code")]
    public partial record Code : BookingUnit1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Method for booking out an order. Used when notifying a broker that an order to be settled by that broker is to be booked out as an Over The Counter derivative (for example, Contract For Difference - CFD or similar).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BookingType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
