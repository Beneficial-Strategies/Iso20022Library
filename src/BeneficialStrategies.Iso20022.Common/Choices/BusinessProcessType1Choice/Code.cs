// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BusinessProcessType1Choice
{
    /// <summary>
    /// Business process type is identified using a code.
    /// </summary>
    [IsoId("_AcY2hdokEeC60axPepSq7g_-863229767")]
    [DisplayName("Code")]
    public partial record Code : BusinessProcessType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of business process model used to carry out the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BusinessProcessType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
