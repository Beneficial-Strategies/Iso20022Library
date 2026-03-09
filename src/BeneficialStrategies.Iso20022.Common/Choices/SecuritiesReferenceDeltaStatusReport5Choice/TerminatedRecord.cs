// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesReferenceDeltaStatusReport5Choice
{
    /// <summary>
    /// Specifies instruments which have been terminated / have reached there pre-set termination data and are no longer valid instruments.
    /// </summary>
    [IsoId("_o1S5haWvEeqZmriXpMtonA")]
    [DisplayName("Terminated Record")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TerminatedRecord : SecuritiesReferenceDeltaStatusReport5Choice_
    #else
    public partial class TerminatedRecord : SecuritiesReferenceDeltaStatusReport5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TerminatedRecord instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TerminatedRecord( SecurityInstrumentDescription9 reqFinancialInstrumentGeneralAttributes,System.String reqIssuer )
        {
            FinancialInstrumentGeneralAttributes = reqFinancialInstrumentGeneralAttributes;
            Issuer = reqIssuer;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// Usage:
        /// This identification will be used in the status advice report sent back.
        /// </summary>
        [IsoId("_LGQmJSX7EeigZbhgJcrASA")]
        [DisplayName("Technical Record Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechRcrdId")]
        #endif
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TechnicalRecordIdentification { get; init; } 
        #else
        public System.String? TechnicalRecordIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes and characteristics of the financial instrument.
        /// </summary>
        [IsoId("_LGQmJyX7EeigZbhgJcrASA")]
        [DisplayName("Financial Instrument General Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmGnlAttrbts")]
        #endif
        [IsoXmlTag("FinInstrmGnlAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; init; } 
        #else
        public SecurityInstrumentDescription9 FinancialInstrumentGeneralAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// LEI of Issuer or trading venue operator.
        /// </summary>
        [IsoId("_LGQmKSX7EeigZbhgJcrASA")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoLEIIdentifier Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Issuer { get; init; } 
        #else
        public System.String Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Traded venue related attributes.
        /// </summary>
        [IsoId("_LGQmKyX7EeigZbhgJcrASA")]
        [DisplayName("Trading Venue Related Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradgVnRltdAttrbts")]
        #endif
        [IsoXmlTag("TradgVnRltdAttrbts")]
        public ValueList<TradingVenueAttributes1> TradingVenueRelatedAttributes { get; init; } = new ValueList<TradingVenueAttributes1>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _LGQmKyX7EeigZbhgJcrASA
        
        /// <summary>
        /// Attributes specific to debt instruments.
        /// </summary>
        [IsoId("_LGQmLSX7EeigZbhgJcrASA")]
        [DisplayName("Debt Instrument Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DebtInstrmAttrbts")]
        #endif
        [IsoXmlTag("DebtInstrmAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DebtInstrument2? DebtInstrumentAttributes { get; init; } 
        #else
        public DebtInstrument2? DebtInstrumentAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes specific to derivative instruments.
        /// </summary>
        [IsoId("_LGQmLyX7EeigZbhgJcrASA")]
        [DisplayName("Derivative Instrument Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DerivInstrmAttrbts")]
        #endif
        [IsoXmlTag("DerivInstrmAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DerivativeInstrument5? DerivativeInstrumentAttributes { get; init; } 
        #else
        public DerivativeInstrument5? DerivativeInstrumentAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Technical attributes.
        /// </summary>
        [IsoId("_LGQmMSX7EeigZbhgJcrASA")]
        [DisplayName("Technical Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechAttrbts")]
        #endif
        [IsoXmlTag("TechAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RecordTechnicalData4? TechnicalAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RecordTechnicalData4? TechnicalAttributes { get; init; } 
        #else
        public RecordTechnicalData4? TechnicalAttributes { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
