// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IsabelEbanking1Choice
{
    /// <summary>
    /// Identification of the e-banking through a contract identification.
    /// </summary>
    [IsoId("_oWi3kMm7EeWAGphE2LvqeA")]
    [DisplayName("Contract Identification")]
    public partial record ContractIdentification : IsabelEbanking1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 13 characters.
        /// </summary>
        [IsoXmlTag("CtrctId")]
        [IsoSimpleType(IsoSimpleType.Max13AlphaNumericText)]
        [StringLength(maximumLength: 13 ,MinimumLength = 1)]
        public required IsoMax13AlphaNumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
