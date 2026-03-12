// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FATCASource1Choice
{
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status expressed as a code.
    /// </summary>
    [IsoId("_pdKdkAjUEeS5F6qHcKOrew")]
    [DisplayName("Code")]
    public partial record Code : FATCASource1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the source of Foreign Account Tax Compliance Act (FATCA) status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FATCASourceStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
