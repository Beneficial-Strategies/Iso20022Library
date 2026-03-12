// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentScheduleType1Choice
{
    /// <summary>
    /// Payment schedule type defined in a coded form.
    /// </summary>
    [IsoId("_Rb3AYAqQEeWqX7rjSIiMuQ")]
    [DisplayName("Code")]
    public partial record Code : PaymentScheduleType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a payment schedule type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PaymentScheduleType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
