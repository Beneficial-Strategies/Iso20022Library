// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRange1Choice
{
    /// <summary>
    /// Lower boundary of a range of amount values.
    /// </summary>
    [IsoId("_O_mxMZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("From Amount")]
    public partial record FromAmount : ImpliedCurrencyAmountRange1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Amount value of the range limit.
        /// </summary>
        [IsoId("_T4ItPNp-Ed-ak6NoX_4Aeg_-1036855293")]
        [DisplayName("Boundary Amount")]
        [IsoXmlTag("BdryAmt")]
        public required ImpliedCurrencyAndAmount BoundaryAmount { get; init; } 
        
        /// <summary>
        /// Indicates whether the boundary amount is included in the range of amount values.
        /// </summary>
        [IsoId("_T4SeMNp-Ed-ak6NoX_4Aeg_-1036855240")]
        [DisplayName("Included")]
        [IsoXmlTag("Incl")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Included { get; init; } 
        
        
        #nullable disable
        
    }
}
