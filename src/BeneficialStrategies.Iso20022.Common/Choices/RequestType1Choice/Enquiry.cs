// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RequestType1Choice
{
    /// <summary>
    /// Request type is an enquiry on the a position or a transaction.
    /// </summary>
    [IsoId("_RZvYINp-Ed-ak6NoX_4Aeg_-503564053")]
    [DisplayName("Enquiry")]
    public partial record Enquiry : RequestType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the request used to further detail the type of information that will be queried.
        /// </summary>
        [IsoXmlTag("Enqry")]
        public required RequestType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
