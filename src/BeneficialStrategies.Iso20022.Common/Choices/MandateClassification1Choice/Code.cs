// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MandateClassification1Choice
{
    /// <summary>
    /// Category purpose, as published in an external category purpose code list.
    /// </summary>
    [IsoId("_JThthWoDEearR-CA7eRZXQ")]
    [DisplayName("Code")]
    public partial record Code : MandateClassification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of direct debit amount, such as fixed or variable.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MandateClassification1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
