// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceSourceFormatChoice
{
    /// <summary>
    /// Source of price quotation is the market, expressed as a Market Identifier Code (MIC).
    /// </summary>
    [IsoId("_RCDQ5Np-Ed-ak6NoX_4Aeg_863703704")]
    [DisplayName("Local Market Place")]
    public partial record LocalMarketPlace : PriceSourceFormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("LclMktPlc")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
