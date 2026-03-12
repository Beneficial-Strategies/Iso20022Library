// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LimitType1Choice
{
    /// <summary>
    /// Type of the limit, in a coded form.
    /// </summary>
    [IsoId("_79FX8aMgEeCJ6YNENx4h-w_418078119")]
    [DisplayName("Code")]
    public partial record Code : LimitType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of risk management limit.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LimitType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
