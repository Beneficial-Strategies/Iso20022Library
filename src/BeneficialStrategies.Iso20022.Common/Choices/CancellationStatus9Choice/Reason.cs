// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus9Choice
{
    /// <summary>
    /// Specifies the reason of the CancellationStatus.
    /// </summary>
    [IsoId("_BF37z_7sEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public partial record Reason : CancellationStatus9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_UT2_5tp-Ed-ak6NoX_4Aeg_-224579490")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason3Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UUAJ0Np-Ed-ak6NoX_4Aeg_-1221651843")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
