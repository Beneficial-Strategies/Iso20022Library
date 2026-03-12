// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UndertakingType1Choice
{
    /// <summary>
    /// Type of undertaking.
    /// </summary>
    [IsoId("_92qY6XltEeG7BsjMvd1mEw_-924081999")]
    [DisplayName("Code")]
    public partial record Code : UndertakingType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external undertaking type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalUndertakingType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
