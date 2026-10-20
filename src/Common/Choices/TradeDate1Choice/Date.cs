// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDate1Choice
{
    /// <summary>
    /// Date expressed as a ISO date.
    /// </summary>
    [IsoId("_Qvaowtp-Ed-ak6NoX_4Aeg_93111248")]
    [DisplayName("Date")]
    public partial record Date : TradeDate1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dt")]
        public required DateAndDateTimeChoice_ Value { get; init; }
    }
}
