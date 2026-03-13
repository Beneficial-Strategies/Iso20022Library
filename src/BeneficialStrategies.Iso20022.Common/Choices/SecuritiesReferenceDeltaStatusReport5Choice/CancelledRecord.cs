// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesReferenceDeltaStatusReport5Choice
{
    /// <summary>
    /// Specifies data that has been cancelled since the previous report.
    /// </summary>
    [IsoId("_o1S5h6WvEeqZmriXpMtonA")]
    [DisplayName("Cancelled Record")]
    public partial record CancelledRecord : SecuritiesReferenceDeltaStatusReport5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// Usage:
        /// This identification will be used in the status advice report sent back.
        /// </summary>
        [IsoId("_EO4YNUmXEeqmSrLQiFB8FA")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
        
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_EO4YN0mXEeqmSrLQiFB8FA")]
        [DisplayName("Financial Instrument General Attributes")]
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        public required SecurityInstrumentDescription17 FinancialInstrumentGeneralAttributes { get; init; } 
        
        /// <summary>
        /// LEI of Issuer or trading venue operator.
        /// </summary>
        [IsoId("_EO4YOUmXEeqmSrLQiFB8FA")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? Issuer { get; init; } 
        
        /// <summary>
        /// Traded venue related attributes.
        /// </summary>
        [IsoId("_EO4YO0mXEeqmSrLQiFB8FA")]
        [DisplayName("Trading Venue Related Attributes")]
        [IsoXmlTag("TradgVnRltdAttrbts")]
        public ValueList<TradingVenueAttributes2> TradingVenueRelatedAttributes { get; init; } = [];
        // ID for the above is _EO4YO0mXEeqmSrLQiFB8FA
        
        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_EO4YPUmXEeqmSrLQiFB8FA")]
        [DisplayName("Debt Instrument Attributes")]
        [IsoXmlTag("DebtInstrmAttrbts")]
        public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_EO4YP0mXEeqmSrLQiFB8FA")]
        [DisplayName("Derivative Instrument Attributes")]
        [IsoXmlTag("DerivInstrmAttrbts")]
        public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Technical attributes.
        /// </summary>
        [IsoId("_EO4YQUmXEeqmSrLQiFB8FA")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public RecordTechnicalData4? TechnicalAttributes { get; init; } 
        
        
        #nullable disable
        
    }
}
