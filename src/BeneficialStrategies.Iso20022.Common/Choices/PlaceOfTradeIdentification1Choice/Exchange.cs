// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification1Choice
{
    /// <summary>
    /// Exchange at which the transaction is executed.
    /// </summary>
    [IsoId("_TCfeodp-Ed-ak6NoX_4Aeg_-1323317101")]
    [DisplayName("Exchange")]
    public partial record Exchange : PlaceOfTradeIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("Xchg")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
