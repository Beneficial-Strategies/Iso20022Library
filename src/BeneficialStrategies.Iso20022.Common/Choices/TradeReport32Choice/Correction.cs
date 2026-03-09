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
namespace BeneficialStrategies.Iso20022.Choices.TradeReport32Choice
{
    /// <summary>
    /// Indicates that the report is correcting the erroneous data fields of a previously submitted report.
    /// </summary>
    [IsoId("__fyLZWEUEe2P-L9DBerEgA")]
    [DisplayName("Correction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Correction : TradeReport32Choice_
    #else
    public partial class Correction : TradeReport32Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Correction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Correction( CommonTradeDataReport69 reqCommonTradeData )
        {
            CommonTradeData = reqCommonTradeData;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_2yMwMWEUEe2P-L9DBerEgA")]
        [DisplayName("Counterparty Specific Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtySpcfcData")]
        #endif
        [IsoXmlTag("CtrPtySpcfcData")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<CounterpartySpecificData36> CounterpartySpecificData { get; init; } = new ValueList<CounterpartySpecificData36>(){};
        
        /// <summary>
        /// Data specifically related to transaction.
        /// </summary>
        [IsoId("_2yMwM2EUEe2P-L9DBerEgA")]
        [DisplayName("Common Trade Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CmonTradData")]
        #endif
        [IsoXmlTag("CmonTradData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CommonTradeDataReport69 CommonTradeData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CommonTradeDataReport69 CommonTradeData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommonTradeDataReport69 CommonTradeData { get; init; } 
        #else
        public CommonTradeDataReport69 CommonTradeData { get; set; } 
        #endif
        
        /// <summary>
        /// Information concerning the reported transaction level type.
        /// Usage: The absence of the code will imply the default value Transaction (TCTN).
        /// </summary>
        [IsoId("_2yMwNWEUEe2P-L9DBerEgA")]
        [DisplayName("Level")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Lvl")]
        #endif
        [IsoXmlTag("Lvl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ModificationLevel1Code? Level { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ModificationLevel1Code? Level { get; init; } 
        #else
        public ModificationLevel1Code? Level { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_2yMwN2EUEe2P-L9DBerEgA")]
        [DisplayName("Technical Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechAttrbts")]
        #endif
        [IsoXmlTag("TechAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TechnicalAttributes5? TechnicalAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TechnicalAttributes5? TechnicalAttributes { get; init; } 
        #else
        public TechnicalAttributes5? TechnicalAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Information regarding the public dissemination of trade data.
        /// </summary>
        [IsoId("_2yMwOWEUEe2P-L9DBerEgA")]
        [DisplayName("Public Dissemination Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PblcDssmntnData")]
        #endif
        [IsoXmlTag("PblcDssmntnData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DisseminationData1? PublicDisseminationData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DisseminationData1? PublicDisseminationData { get; init; } 
        #else
        public DisseminationData1? PublicDisseminationData { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_2yMwO2EUEe2P-L9DBerEgA")]
        [DisplayName("Supplementary Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SplmtryData")]
        #endif
        [IsoXmlTag("SplmtryData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SupplementaryData1? SupplementaryData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryData1? SupplementaryData { get; init; } 
        #else
        public SupplementaryData1? SupplementaryData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
