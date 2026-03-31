// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SupervisingAuthorityIdentification1Choice
{
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to an institution using an external code list.
    /// </summary>
    [IsoId("_IamycfIAEeaz_YGUGLjP6A")]
    [DisplayName("Proprietary Identification")]
    public record ProprietaryIdentification : SupervisingAuthorityIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external authority identification scheme name code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("PrtryId")]
        public required ExternalAuthorityIdentification1Code Value { get; init; }
    }
}
