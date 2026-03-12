// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LocalInstrument1Choice
{
    /// <summary>
    /// Specifies the local instrument published in an external local instrument code list.
    /// </summary>
    [IsoId("_TGhDCNp-Ed-ak6NoX_4Aeg_-2017969272")]
    [DisplayName("Code")]
    public partial record Code : LocalInstrument1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external local instrument code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately.
        /// </summary>
        [IsoXmlTag("Cd")]
        [IsoSimpleType(IsoSimpleType.ExternalLocalInstrumentCode_Obsolete)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoExternalLocalInstrumentCode_Obsolete Value { get; init; } 
        
        
        #nullable disable
        
    }
}
