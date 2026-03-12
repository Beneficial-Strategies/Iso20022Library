// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PlannedQuantity1Choice
{
    /// <summary>
    /// Code for the planned quantity of financial instrument or lot of rights/warrants to be purchased.
    /// </summary>
    [IsoId("_FiTKMDF1EeGKkIZzgd38VA")]
    [DisplayName("Code")]
    public partial record Code : PlannedQuantity1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// TSE/JASDEC codes for unknown number of shares to be purchased.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesQuantity2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
