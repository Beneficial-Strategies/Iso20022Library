// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes5Choice
{
    /// <summary>
    /// Description of the financial instrument, such as a a derivative, when the instrument is not admitted to trading on a trading venue.
    /// </summary>
    [IsoId("_6geZA5icEe2f7NHvXATP5g")]
    [DisplayName("Other")]
    public partial record Other : FinancialInstrumentAttributes5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_2oQU0ZidEe2f7NHvXATP5g")]
        [DisplayName("Financial Instrument General Attributes")]
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        public required SecurityInstrumentDescription23 FinancialInstrumentGeneralAttributes { get; init; } 
        
        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_2oQU05idEe2f7NHvXATP5g")]
        [DisplayName("Debt Instrument Attributes")]
        [IsoXmlTag("DebtInstrmAttrbts")]
        public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_2oQU1ZidEe2f7NHvXATP5g")]
        [DisplayName("Derivative Instrument Attributes")]
        [IsoXmlTag("DerivInstrmAttrbts")]
        public required DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
        
        
        #nullable disable
        
    }
}
