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
namespace BeneficialStrategies.Iso20022.Choices.InstrumentOrSubClassIdentification2Choice
{
    /// <summary>
    /// Identifies the asset class and sub-class of non-equity instruments to which the result relates
    /// </summary>
    [IsoId("_BSnWY6aUEeqZmriXpMtonA")]
    [DisplayName("Asset Class And Sub Class")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AssetClassAndSubClass : InstrumentOrSubClassIdentification2Choice_
    #else
    public partial class AssetClassAndSubClass : InstrumentOrSubClassIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AssetClassAndSubClass instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AssetClassAndSubClass( NonEquityAssetClass1Code reqAssetClass )
        {
            AssetClass = reqAssetClass;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Asset class of non-equity instruments to which the result relates
        /// </summary>
        [IsoId("_cBU0saaUEeqZmriXpMtonA")]
        [DisplayName("Asset Class")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AsstClss")]
        #endif
        [IsoXmlTag("AsstClss")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NonEquityAssetClass1Code AssetClass { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NonEquityAssetClass1Code AssetClass { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NonEquityAssetClass1Code AssetClass { get; init; } 
        #else
        public NonEquityAssetClass1Code AssetClass { get; set; } 
        #endif
        
        /// <summary>
        /// Sub class of non-equity instruments to which the result relates, as defined in the local regulation.
        /// </summary>
        [IsoId("_cBU0s6aUEeqZmriXpMtonA")]
        [DisplayName("Derivative Sub Class")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DerivSubClss")]
        #endif
        [IsoXmlTag("DerivSubClss")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NonEquitySubClass1? DerivativeSubClass { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NonEquitySubClass1? DerivativeSubClass { get; init; } 
        #else
        public NonEquitySubClass1? DerivativeSubClass { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of non-equity financial instruments.
        /// </summary>
        [IsoId("_cBU0taaUEeqZmriXpMtonA")]
        [DisplayName("Financial Instrument Classification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmClssfctn")]
        #endif
        [IsoXmlTag("FinInstrmClssfctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
        #else
        public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
