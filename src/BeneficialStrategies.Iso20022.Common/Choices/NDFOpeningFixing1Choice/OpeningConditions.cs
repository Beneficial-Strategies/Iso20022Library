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
namespace BeneficialStrategies.Iso20022.Choices.NDFOpeningFixing1Choice
{
    /// <summary>
    /// Used to provide the opening information associated with an NDF trade.
    /// </summary>
    [IsoId("_hvh9oLC1EeaYscKJ1tWGRA")]
    [DisplayName("Opening Conditions")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OpeningConditions : NDFOpeningFixing1Choice_
    #else
    public partial class OpeningConditions : NDFOpeningFixing1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OpeningConditions instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OpeningConditions( string reqSettlementCurrency,System.DateOnly reqValuationDate )
        {
            SettlementCurrency = reqSettlementCurrency;
            ValuationDate = reqValuationDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the settlement currency of the non deliverable trade.
        /// </summary>
        [IsoId("_teDWYJR-Eeak6e8_Fc5fQg")]
        [DisplayName("Settlement Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmCcy")]
        #endif
        [IsoXmlTag("SttlmCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyCode SettlementCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string SettlementCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string SettlementCurrency { get; init; } 
        #else
        public string SettlementCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the valuation date for a non deliverable trade.
        /// </summary>
        [IsoId("_XAtxMJR_Eeak6e8_Fc5fQg")]
        [DisplayName("Valuation Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ValtnDt")]
        #endif
        [IsoXmlTag("ValtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ValuationDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly ValuationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ValuationDate { get; init; } 
        #else
        public System.DateOnly ValuationDate { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the rate source associated with the non deliverable trade.
        /// </summary>
        [IsoId("_q4iDMJUOEeak6e8_Fc5fQg")]
        [DisplayName("Settlement Rate Source")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmRateSrc")]
        #endif
        [IsoXmlTag("SttlmRateSrc")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<SettlementRateSource1> SettlementRateSource { get; init; } = new ValueList<SettlementRateSource1>(){};
        
        
        #nullable disable
        
    }
}
