// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CRSForm1Choice
{
    /// <summary>
    /// Type of Foreign Account Tax Compliance Act (FATCA) form expressed as a code.
    /// </summary>
    [IsoId("_gFvEIUNuEeaS-NnwLNvMPg")]
    [DisplayName("Code")]
    public partial record Code : CRSForm1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of Common Reporting Standard (CRS) form.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CRSFormType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
