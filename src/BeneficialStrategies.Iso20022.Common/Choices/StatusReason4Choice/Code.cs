// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusReason4Choice
{
    /// <summary>
    /// Reason for the status in a coded form.
    /// </summary>
    [IsoId("_TPdjptp-Ed-ak6NoX_4Aeg_46429953")]
    [DisplayName("Code")]
    public partial record Code : StatusReason4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the coded reason for the financing status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FinancingStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
