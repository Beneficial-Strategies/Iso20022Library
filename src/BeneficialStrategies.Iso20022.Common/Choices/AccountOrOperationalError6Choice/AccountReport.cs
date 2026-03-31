// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountOrOperationalError6Choice
{
    /// <summary>
    /// Account Report.
    /// </summary>
    [DisplayName("Account Report")]
    public record AccountReport : AccountOrOperationalError6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AcctRpt")]
        public required AccountReport35 Value { get; init; }
    }
}
