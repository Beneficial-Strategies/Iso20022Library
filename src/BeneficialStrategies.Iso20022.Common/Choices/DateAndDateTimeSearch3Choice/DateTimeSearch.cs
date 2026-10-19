// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTimeSearch3Choice
{
    /// <summary>
    /// Patterns to search a date time.
    /// </summary>
    [IsoId("_x03f4ZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Date Time Search")]
    public partial record DateTimeSearch : DateAndDateTimeSearch3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtTmSch")]
        public required DateTimePeriod1Choice_ Value { get; init; }
    }
}
