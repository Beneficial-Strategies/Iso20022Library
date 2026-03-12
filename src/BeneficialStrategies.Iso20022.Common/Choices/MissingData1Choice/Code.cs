// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MissingData1Choice
{
    /// <summary>
    /// Missing data type, in a coded form.
    /// </summary>
    [IsoId("_MN6wldjMEeq5MfBBxQig1Q")]
    [DisplayName("Code")]
    public partial record Code : MissingData1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalUnableToApplyMissingData1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
