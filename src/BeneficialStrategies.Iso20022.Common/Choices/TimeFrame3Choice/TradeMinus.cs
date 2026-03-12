// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TimeFrame3Choice
{
    /// <summary>
    /// An agreed number of days before the Trade date (T) used to define standard timeframes e.g. T-1 Dealing cut off or T-2 prepayment condition||Where = T is the date that the price is applied to a transaction.
    /// </summary>
    [IsoId("_UAyS49p-Ed-ak6NoX_4Aeg_669671935")]
    [DisplayName("Trade Minus")]
    public partial record TradeMinus : TimeFrame3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("TMns")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
