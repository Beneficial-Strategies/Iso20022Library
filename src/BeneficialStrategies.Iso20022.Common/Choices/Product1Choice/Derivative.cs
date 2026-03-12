// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Product1Choice
{
    /// <summary>
    /// Derivative specific attributes.
    /// </summary>
    [IsoId("_IojKYLVQEeadLcJesEbkTQ")]
    [DisplayName("Derivative")]
    public partial record Derivative : Product1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Hierarchy of classification of a derivative.
        /// </summary>
        [IsoId("_hUAMALcHEeabfchHYoktpA")]
        [DisplayName("Derivative Classification")]
        [IsoXmlTag("DerivClssfctn")]
        public required DerivativeClassification1 DerivativeClassification { get; init; } 
        
        /// <summary>
        /// Rate(s) that determine(s)) the value of the swap during the lifetime of the trade. Where both rates are fixed this does not need to be reported.
        /// </summary>
        [IsoId("_iQdcUMhiEeadgvwNGwK05w")]
        [DisplayName("Derivative Underlying Leg")]
        [IsoXmlTag("DerivUndrlygLeg")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<DerivativeUnderlyingLeg1> DerivativeUnderlyingLeg { get; init; } = new ValueList<DerivativeUnderlyingLeg1>(){};
        
        /// <summary>
        /// Option specific attributes.
        /// </summary>
        [IsoId("_a8zBcMhiEeadgvwNGwK05w")]
        [DisplayName("Option Attributes")]
        [IsoXmlTag("OptnAttrbts")]
        public Option14? OptionAttributes { get; init; } 
        
        
        #nullable disable
        
    }
}
