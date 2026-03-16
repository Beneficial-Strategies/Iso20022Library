// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesReferenceDeltaStatusReport3Choice
{
    /// <summary>
    /// Specifies new instruments that have been added since the previous report.
    /// </summary>
    [IsoId("_PjgBoydoEei12pGEsJIAeQ")]
    [DisplayName("New Record")]
    [IsoXmlTag("NewRcrd")]
    public record NewRecord : SecuritiesReferenceDeltaStatusReport3Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// Usage:
        /// This identification will be used in the status advice report sent back.
        /// </summary>
        [IsoId("_LGQmJSX7EeigZbhgJcrASA")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_LGQmJyX7EeigZbhgJcrASA")]
        [DisplayName("Financial Instrument General Attributes")]
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        public required SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; init; }

        /// <summary>
        /// LEI of Issuer or trading venue operator.
        /// </summary>
        [IsoId("_LGQmKSX7EeigZbhgJcrASA")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Issuer { get; init; }

        /// <summary>
        /// Traded venue related attributes.
        /// </summary>
        [IsoId("_LGQmKyX7EeigZbhgJcrASA")]
        [DisplayName("Trading Venue Related Attributes")]
        [IsoXmlTag("TradgVnRltdAttrbts")]
        public ValueList<TradingVenueAttributes1> TradingVenueRelatedAttributes { get; init; } = [];

        // ID for the above is _LGQmKyX7EeigZbhgJcrASA

        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_LGQmLSX7EeigZbhgJcrASA")]
        [DisplayName("Debt Instrument Attributes")]
        [IsoXmlTag("DebtInstrmAttrbts")]
        public DebtInstrument2? DebtInstrumentAttributes { get; init; }

        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_LGQmLyX7EeigZbhgJcrASA")]
        [DisplayName("Derivative Instrument Attributes")]
        [IsoXmlTag("DerivInstrmAttrbts")]
        public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; }

        /// <summary>
        /// Technical attributes.
        /// </summary>
        [IsoId("_LGQmMSX7EeigZbhgJcrASA")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public RecordTechnicalData4? TechnicalAttributes { get; init; }
    }
}
