// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CRSSource1Choice
{
    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status expressed as a code.
    /// </summary>
    [IsoId("_J3oBAUNfEeamLdeYEZm56w")]
    [DisplayName("Code")]
    public partial record Code : CRSSource1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the source of Common Reporting Standard (CRS) status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CRSSourceStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
