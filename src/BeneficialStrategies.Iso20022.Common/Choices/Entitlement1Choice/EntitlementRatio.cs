// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Entitlement1Choice
{
    /// <summary>
    /// Number of votes assigned to one security.
    /// </summary>
    [IsoId("_RDrol9p-Ed-ak6NoX_4Aeg_362471814")]
    [DisplayName("Entitlement Ratio")]
    public partial record EntitlementRatio : Entitlement1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("EntitlmntRatio")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
