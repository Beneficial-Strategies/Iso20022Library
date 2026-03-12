// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxAmountType1Choice
{
    /// <summary>
    /// Specifies the amount type, in a coded form.
    /// </summary>
    [IsoId("_tsra01kyEeGeoaLUQk__nA_1392476130")]
    [DisplayName("Code")]
    public partial record Code : TaxAmountType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTaxAmountType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
