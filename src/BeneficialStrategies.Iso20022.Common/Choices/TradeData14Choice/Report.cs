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
namespace BeneficialStrategies.Iso20022.Choices.TradeData14Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_CpO6Y__oEemm3skPVSMJQg")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : TradeData14Choice_
    #else
    public partial class Report : TradeData14Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Status of the required transactions reconciliation or pairing.
        /// </summary>
        [IsoId("_CtHU0f_oEemm3skPVSMJQg")]
        [DisplayName("Pairing Reconciliation Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PairgRcncltnSts")]
        #endif
        [IsoXmlTag("PairgRcncltnSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NumberOfReportsPerStatus2? PairingReconciliationStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NumberOfReportsPerStatus2? PairingReconciliationStatus { get; init; } 
        #else
        public NumberOfReportsPerStatus2? PairingReconciliationStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Data on transaction requiring reconciliation or pairing. 
        /// </summary>
        [IsoId("_CtHU0__oEemm3skPVSMJQg")]
        [DisplayName("Reconciliation Report")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcncltnRpt")]
        #endif
        [IsoXmlTag("RcncltnRpt")]
        public ValueList<ReconciliationReport5> ReconciliationReport { get; init; } = new ValueList<ReconciliationReport5>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _CtHU0__oEemm3skPVSMJQg
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_CtHU1f_oEemm3skPVSMJQg")]
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
