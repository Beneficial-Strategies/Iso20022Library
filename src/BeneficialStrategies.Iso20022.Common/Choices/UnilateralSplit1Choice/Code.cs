// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnilateralSplit1Choice
{
    /// <summary>
    /// Unilateral split expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QtogGtp-Ed-ak6NoX_4Aeg_396862937")]
    [DisplayName("Code")]
    public partial record Code : UnilateralSplit1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesTransactionType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
