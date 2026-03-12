// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExemptionReasonType1Choice
{
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_RgcdENp-Ed-ak6NoX_4Aeg_685334250")]
    [DisplayName("Exemption Reason")]
    public partial record ExemptionReason : ExemptionReasonType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
        /// </summary>
        [IsoXmlTag("XmptnRsn")]
        public required TaxExemptReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
