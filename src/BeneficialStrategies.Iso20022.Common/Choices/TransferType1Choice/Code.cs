// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferType1Choice
{
    /// <summary>
    /// Transfer type expressed as a code.
    /// </summary>
    [IsoId("_Yre24E3VEeidB49bWZiS0g")]
    [DisplayName("Code")]
    public partial record Code : TransferType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether a financial instrument is transferred as an asset or as cash.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransferType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
