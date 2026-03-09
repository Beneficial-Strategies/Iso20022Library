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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification6Choice
{
    /// <summary>
    /// Provides the ability to describe the instrument through a description and main characteristics.
    /// </summary>
    [IsoId("_TBKB8tp-Ed-ak6NoX_4Aeg_-1421894924")]
    [DisplayName("Instrument Description")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record InstrumentDescription : SecurityIdentification6Choice_
    #else
    public partial class InstrumentDescription : SecurityIdentification6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Description of the security.
        /// </summary>
        [IsoId("_S1FUwNp-Ed-ak6NoX_4Aeg_1287302984")]
        [DisplayName("Description")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Desc")]
        #endif
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? Description { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Description { get; init; } 
        #else
        public System.String? Description { get; set; } 
        #endif
        
        /// <summary>
        /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, eg, common share with voting rights, fully paid, or registered.
        /// </summary>
        [IsoId("_S1FUwdp-Ed-ak6NoX_4Aeg_1023322278")]
        [DisplayName("Classification Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClssfctnTp")]
        #endif
        [IsoXmlTag("ClssfctnTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecurityClassificationType1Choice_? ClassificationType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityClassificationType1Choice_? ClassificationType { get; init; } 
        #else
        public SecurityClassificationType1Choice_? ClassificationType { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the place of listing using a market identifier code (MIC).
        /// </summary>
        [IsoId("_S1FUwtp-Ed-ak6NoX_4Aeg_1288222996")]
        [DisplayName("Place Of Listing")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PlcOfListg")]
        #endif
        [IsoXmlTag("PlcOfListg")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMICIdentifier? PlaceOfListing { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PlaceOfListing { get; init; } 
        #else
        public System.String? PlaceOfListing { get; set; } 
        #endif
        
        /// <summary>
        /// Exercise date/time of a derivative contract.
        /// </summary>
        [IsoId("_S1FUw9p-Ed-ak6NoX_4Aeg_1288223013")]
        [DisplayName("Exercise Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExrcDt")]
        #endif
        [IsoXmlTag("ExrcDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ExerciseDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ExerciseDate { get; init; } 
        #else
        public System.DateOnly? ExerciseDate { get; set; } 
        #endif
        
        /// <summary>
        /// Maturity date/time at which an interest bearing security becomes due.
        /// </summary>
        [IsoId("_S1FUxNp-Ed-ak6NoX_4Aeg_1288223031")]
        [DisplayName("Maturity Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MtrtyDt")]
        #endif
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? MaturityDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? MaturityDate { get; init; } 
        #else
        public System.DateOnly? MaturityDate { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
        /// </summary>
        [IsoId("_S1FUxdp-Ed-ak6NoX_4Aeg_1288223048")]
        [DisplayName("Option Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OptnTp")]
        #endif
        [IsoXmlTag("OptnTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OptionTypeCode? OptionType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OptionTypeCode? OptionType { get; init; } 
        #else
        public OptionTypeCode? OptionType { get; set; } 
        #endif
        
        /// <summary>
        /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
        /// </summary>
        [IsoId("_S1FUxtp-Ed-ak6NoX_4Aeg_1288223066")]
        [DisplayName("Strike Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StrkPric")]
        #endif
        [IsoXmlTag("StrkPric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PriceRateOrAmountChoice_? StrikePrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceRateOrAmountChoice_? StrikePrice { get; init; } 
        #else
        public PriceRateOrAmountChoice_? StrikePrice { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the ratio or multiplying factor used to convert one contract into a quantity. In the case of an equity or a bond, the price multiplier is 1.
        /// </summary>
        [IsoId("_S1FUx9p-Ed-ak6NoX_4Aeg_1288223091")]
        [DisplayName("Multiplier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Mltplr")]
        #endif
        [IsoXmlTag("Mltplr")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoBaseOneRate? Multiplier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? Multiplier { get; init; } 
        #else
        public System.Decimal? Multiplier { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
