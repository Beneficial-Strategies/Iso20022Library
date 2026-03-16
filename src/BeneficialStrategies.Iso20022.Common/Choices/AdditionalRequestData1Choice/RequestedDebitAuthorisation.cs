// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdditionalRequestData1Choice
{
    /// <summary>
    /// Requested Debit Authorisation.
    /// </summary>
    [DisplayName("Requested Debit Authorisation")]
    public partial record RequestedDebitAuthorisation : AdditionalRequestData1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ReqdDbtAuthstn")]
        public required DebitAuthorisation3 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
