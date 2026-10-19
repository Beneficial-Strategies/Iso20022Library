// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SortCriteria1Choice
{
    /// <summary>
    /// User-defined way of indicating how the information is broken down.
    /// </summary>
    [IsoId("_U1-1htp-Ed-ak6NoX_4Aeg_1863721996")]
    [DisplayName("User Defined")]
    public partial record UserDefined : SortCriteria1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UsrDfnd")]
        public required DataFormat1Choice_ Value { get; init; }
    }
}
