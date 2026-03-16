// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice
{
    /// <summary>
    /// Reporting source, as published in an external reporting source code list.
    /// </summary>
    [IsoId("_RqIkktp-Ed-ak6NoX_4Aeg_-1706426890")]
    [DisplayName("Code")]
    public record Code : ReportingSource1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reporting source, as published in an external reporting source code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalReportingSource1Code Value { get; init; }
    }
}
