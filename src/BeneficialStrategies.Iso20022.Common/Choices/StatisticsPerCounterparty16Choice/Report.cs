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
namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty16Choice
{
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_rpsLQ1owEe23K4GXSpBSeg")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : StatisticsPerCounterparty16Choice_
    #else
    public partial class Report : StatisticsPerCounterparty16Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( System.DateOnly reqReferenceDate,DetailedMissingValuationsStatistics4Choice_ reqMissingValuation,DetailedMissingMarginInformationStatistics4Choice_ reqMissingMarginInformation,DetailedAbnormalValuesStatistics4Choice_ reqAbnormalValues )
        {
            ReferenceDate = reqReferenceDate;
            MissingValuation = reqMissingValuation;
            MissingMarginInformation = reqMissingMarginInformation;
            AbnormalValues = reqAbnormalValues;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference date for statistics collection.
        /// </summary>
        [IsoId("_rqy-gVowEe23K4GXSpBSeg")]
        [DisplayName("Reference Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RefDt")]
        #endif
        [IsoXmlTag("RefDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ReferenceDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly ReferenceDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ReferenceDate { get; init; } 
        #else
        public System.DateOnly ReferenceDate { get; set; } 
        #endif
        
        /// <summary>
        /// Detailed information of outstanding derivatives for which the valuation was not reported or the valuation reported is more than fourteen calendar days earlier than the date for which the report was generated shall be included in the report of missing valuations at the end of the day.
        /// </summary>
        [IsoId("_rqy-g1owEe23K4GXSpBSeg")]
        [DisplayName("Missing Valuation")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MssngValtn")]
        #endif
        [IsoXmlTag("MssngValtn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DetailedMissingValuationsStatistics4Choice_ MissingValuation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DetailedMissingValuationsStatistics4Choice_ MissingValuation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DetailedMissingValuationsStatistics4Choice_ MissingValuation { get; init; } 
        #else
        public DetailedMissingValuationsStatistics4Choice_ MissingValuation { get; set; } 
        #endif
        
        /// <summary>
        /// Detailed information of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
        /// </summary>
        [IsoId("_rqy-hVowEe23K4GXSpBSeg")]
        [DisplayName("Missing Margin Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MssngMrgnInf")]
        #endif
        [IsoXmlTag("MssngMrgnInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DetailedMissingMarginInformationStatistics4Choice_ MissingMarginInformation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DetailedMissingMarginInformationStatistics4Choice_ MissingMarginInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DetailedMissingMarginInformationStatistics4Choice_ MissingMarginInformation { get; init; } 
        #else
        public DetailedMissingMarginInformationStatistics4Choice_ MissingMarginInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Detailed information of the derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
        /// </summary>
        [IsoId("_rqy-h1owEe23K4GXSpBSeg")]
        [DisplayName("Abnormal Values")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AbnrmlVals")]
        #endif
        [IsoXmlTag("AbnrmlVals")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DetailedAbnormalValuesStatistics4Choice_ AbnormalValues { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DetailedAbnormalValuesStatistics4Choice_ AbnormalValues { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DetailedAbnormalValuesStatistics4Choice_ AbnormalValues { get; init; } 
        #else
        public DetailedAbnormalValuesStatistics4Choice_ AbnormalValues { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
