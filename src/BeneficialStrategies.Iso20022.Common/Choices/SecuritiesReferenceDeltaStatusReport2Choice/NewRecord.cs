// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesReferenceDeltaStatusReport2Choice
{
    /// <summary>
    /// Specifies new instruments that have been added since the previous report.
    /// </summary>
    [IsoId("_2XC94Hv0EeanCNPcMT7sSg")]
    [DisplayName("New Record")]
    public partial record NewRecord : SecuritiesReferenceDeltaStatusReport2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// Usage:
        /// This identification will be used in the status advice report sent back.
        /// </summary>
        [IsoId("_G_iQlX5aEea2k7EBUopqxw")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
        
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_G_iQl35aEea2k7EBUopqxw")]
        [DisplayName("Financial Instrument General Attributes")]
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        public required SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; init; } 
        
        /// <summary>
        /// LEI of Issuer or trading venue operator.
        /// </summary>
        [IsoId("_G_iQmX5aEea2k7EBUopqxw")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Issuer { get; init; } 
        
        /// <summary>
        /// Traded venue related attributes.
        /// </summary>
        [IsoId("_G_iQm35aEea2k7EBUopqxw")]
        [DisplayName("Trading Venue Related Attributes")]
        [IsoXmlTag("TradgVnRltdAttrbts")]
        public ValueList<TradingVenueAttributes1> TradingVenueRelatedAttributes { get; init; } = [];
        // ID for the above is _G_iQm35aEea2k7EBUopqxw
        
        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_G_iQnX5aEea2k7EBUopqxw")]
        [DisplayName("Debt Instrument Attributes")]
        [IsoXmlTag("DebtInstrmAttrbts")]
        public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_G_iQn35aEea2k7EBUopqxw")]
        [DisplayName("Derivative Instrument Attributes")]
        [IsoXmlTag("DerivInstrmAttrbts")]
        public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Technical attributes.
        /// </summary>
        [IsoId("_G_iQoX5aEea2k7EBUopqxw")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public RecordTechnicalData3? TechnicalAttributes { get; init; } 
        
        
        #nullable disable
        
    }
}
