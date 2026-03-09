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
namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty1Choice
{
    /// <summary>
    /// Detailed statistics per counterparty.
    /// </summary>
    [IsoId("_98o1t0wVEeqwfMIOLcNxbw")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : StatisticsPerCounterparty1Choice_
    #else
    public partial class Report : StatisticsPerCounterparty1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( System.DateOnly reqReferenceDate,TradeCounterpartyReport9 reqCounterpartyIdentification,ReconciliationStatisticsPerDerivativeContractGroup3 reqReconciliationStatistics )
        {
            ReferenceDate = reqReferenceDate;
            CounterpartyIdentification = reqCounterpartyIdentification;
            ReconciliationStatistics = reqReconciliationStatistics;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference date for statistics collection.
        /// </summary>
        [IsoId("_5fuIcVfcEeqZr5K1Woax-g")]
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
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_5fuIc1fcEeqZr5K1Woax-g")]
        [DisplayName("Counterparty Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyId")]
        #endif
        [IsoXmlTag("CtrPtyId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TradeCounterpartyReport9 CounterpartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TradeCounterpartyReport9 CounterpartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeCounterpartyReport9 CounterpartyIdentification { get; init; } 
        #else
        public TradeCounterpartyReport9 CounterpartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Detailed information on derivatives submitted for reconciliation.
        /// </summary>
        [IsoId("_5fuIdVfcEeqZr5K1Woax-g")]
        [DisplayName("Reconciliation Statistics")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcncltnSttstcs")]
        #endif
        [IsoXmlTag("RcncltnSttstcs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReconciliationStatisticsPerDerivativeContractGroup3 ReconciliationStatistics { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReconciliationStatisticsPerDerivativeContractGroup3 ReconciliationStatistics { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReconciliationStatisticsPerDerivativeContractGroup3 ReconciliationStatistics { get; init; } 
        #else
        public ReconciliationStatisticsPerDerivativeContractGroup3 ReconciliationStatistics { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the competent authority which supervises the reporting counterparty.
        /// </summary>
        [IsoId("_5fuId1fcEeqZr5K1Woax-g")]
        [DisplayName("Competent Authority")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CmptntAuthrty")]
        #endif
        [IsoXmlTag("CmptntAuthrty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompetentAuthority1? CompetentAuthority { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompetentAuthority1? CompetentAuthority { get; init; } 
        #else
        public CompetentAuthority1? CompetentAuthority { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
