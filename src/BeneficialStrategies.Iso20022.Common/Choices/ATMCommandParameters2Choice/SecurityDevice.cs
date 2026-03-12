// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice
{
    /// <summary>
    /// Parameters to be used to update the configuration or the status security device.
    /// </summary>
    [IsoId("_InOGIItIEeSxlKlAGYErFg")]
    [DisplayName("Security Device")]
    public partial record SecurityDevice : ATMCommandParameters2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Serial number of the device.
        /// </summary>
        [IsoId("_ObyFwItIEeSxlKlAGYErFg")]
        [DisplayName("Serial Number")]
        [IsoXmlTag("SrlNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SerialNumber { get; init; } 
        
        /// <summary>
        /// Update of the security configuration to apply on the security module of the ATM.
        /// </summary>
        [IsoId("_Sp8IQItIEeSxlKlAGYErFg")]
        [DisplayName("Required Configuration")]
        [IsoXmlTag("ReqrdCfgtn")]
        public ATMSecurityConfiguration1? RequiredConfiguration { get; init; } 
        
        /// <summary>
        /// New status to apply on the security module of the ATM.
        /// </summary>
        [IsoId("_W1WYwItIEeSxlKlAGYErFg")]
        [DisplayName("Required Status")]
        [IsoXmlTag("ReqrdSts")]
        public ATMStatus2Code? RequiredStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
