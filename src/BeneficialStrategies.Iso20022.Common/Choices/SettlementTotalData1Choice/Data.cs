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
namespace BeneficialStrategies.Iso20022.Choices.SettlementTotalData1Choice
{
    /// <summary>
    /// Aggregated data of settlement instructions.
    /// </summary>
    [IsoId("_hwwPwB2nEeqF2P5v-Rtejg")]
    [DisplayName("Data")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Data : SettlementTotalData1Choice_
    #else
    public partial class Data : SettlementTotalData1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Data instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Data( SettlementDataVolume2 reqSettled,SettlementDataVolume2 reqFailed,SettlementDataVolume2 reqTotal,SettlementDataRate2 reqFailedRate )
        {
            Settled = reqSettled;
            Failed = reqFailed;
            Total = reqTotal;
            FailedRate = reqFailedRate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Aggregated volume and value of settlement instructions settled during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
        /// </summary>
        [IsoId("_oVUHM40TEemUAO64Q252gQ")]
        [DisplayName("Settled")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sttld")]
        #endif
        [IsoXmlTag("Sttld")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDataVolume2 Settled { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDataVolume2 Settled { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDataVolume2 Settled { get; init; } 
        #else
        public SettlementDataVolume2 Settled { get; set; } 
        #endif
        
        /// <summary>
        /// Aggregated volume and value of settlement instructions failed during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
        /// </summary>
        [IsoId("_oVUHNI0TEemUAO64Q252gQ")]
        [DisplayName("Failed")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Faild")]
        #endif
        [IsoXmlTag("Faild")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDataVolume2 Failed { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDataVolume2 Failed { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDataVolume2 Failed { get; init; } 
        #else
        public SettlementDataVolume2 Failed { get; set; } 
        #endif
        
        /// <summary>
        /// Aggregated total volume and value of settlement instructions performed (settled and failed) during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
        /// </summary>
        [IsoId("_oVUHMY0TEemUAO64Q252gQ")]
        [DisplayName("Total")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ttl")]
        #endif
        [IsoXmlTag("Ttl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDataVolume2 Total { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDataVolume2 Total { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDataVolume2 Total { get; init; } 
        #else
        public SettlementDataVolume2 Total { get; set; } 
        #endif
        
        /// <summary>
        /// Rate of failed settlement instructions compared to the total volume and value, of settlement instructions performed (settled and failed) during the period covered by the report.
        /// </summary>
        [IsoId("_oVUHMo0TEemUAO64Q252gQ")]
        [DisplayName("Failed Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FaildRate")]
        #endif
        [IsoXmlTag("FaildRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDataRate2 FailedRate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDataRate2 FailedRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDataRate2 FailedRate { get; init; } 
        #else
        public SettlementDataRate2 FailedRate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
