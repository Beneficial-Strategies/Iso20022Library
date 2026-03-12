// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReservationType1Choice
{
    /// <summary>
    /// Liquidity transfer request type, in a coded form.
    /// </summary>
    [IsoId("_8JKFEaMgEeCJ6YNENx4h-w_799887441")]
    [DisplayName("Code")]
    public partial record Code : ReservationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the precise type of reservation.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ReservationType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
