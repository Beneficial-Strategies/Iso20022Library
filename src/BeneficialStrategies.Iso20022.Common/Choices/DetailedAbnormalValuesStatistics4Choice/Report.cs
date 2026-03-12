// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DetailedAbnormalValuesStatistics4Choice
{
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_x4ww41yGEe24CqbZJK5XxA")]
    [DisplayName("Report")]
    public partial record Report : DetailedAbnormalValuesStatistics4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number of reported derivatives.
        /// </summary>
        [IsoId("_x5wPYVyGEe24CqbZJK5XxA")]
        [DisplayName("Number Of Derivatives Reported")]
        [IsoXmlTag("NbOfDerivsRptd")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber NumberOfDerivativesReported { get; init; } 
        
        /// <summary>
        /// Number of reported derivatives with outliers.
        /// </summary>
        [IsoId("_x5wPY1yGEe24CqbZJK5XxA")]
        [DisplayName("Number Of Derivatives Reported With Outliers")]
        [IsoXmlTag("NbOfDerivsRptdWthOtlrs")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber NumberOfDerivativesReportedWithOutliers { get; init; } 
        
        /// <summary>
        /// Details of abnormal values.
        /// </summary>
        [IsoId("_x5wPZVyGEe24CqbZJK5XxA")]
        [DisplayName("Warnings")]
        [IsoXmlTag("Wrnngs")]
        public ValueList<AbnormalValuesData4> Warnings { get; init; } = new ValueList<AbnormalValuesData4>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _x5wPZVyGEe24CqbZJK5XxA
        
        
        #nullable disable
        
    }
}
