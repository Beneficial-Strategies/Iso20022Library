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
namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty15Choice
{
    /// <summary>
    /// Detailed statistics per counterparty.
    /// </summary>
    [IsoId("_cFghI1ovEe23K4GXSpBSeg")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : StatisticsPerCounterparty15Choice_
    #else
    public partial class Report : StatisticsPerCounterparty15Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( System.DateOnly reqReferenceDate,ReportingRequirement2Choice_ reqReconciliationCategories )
        {
            ReferenceDate = reqReferenceDate;
            ReconciliationCategories = reqReconciliationCategories;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference date for statistics collection.
        /// </summary>
        [IsoId("_cHFOcVovEe23K4GXSpBSeg")]
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
        /// Different categories of statuses for a derivative.
        /// </summary>
        [IsoId("_cHFOc1ovEe23K4GXSpBSeg")]
        [DisplayName("Reconciliation Categories")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcncltnCtgrs")]
        #endif
        [IsoXmlTag("RcncltnCtgrs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReportingRequirement2Choice_ ReconciliationCategories { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReportingRequirement2Choice_ ReconciliationCategories { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReportingRequirement2Choice_ ReconciliationCategories { get; init; } 
        #else
        public ReportingRequirement2Choice_ ReconciliationCategories { get; set; } 
        #endif
        
        /// <summary>
        /// Number of all reports per status on derivatives submitted for reconciliation.
        /// </summary>
        [IsoId("_cHFOdVovEe23K4GXSpBSeg")]
        [DisplayName("Total Number Of Transactions")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TtlNbOfTxs")]
        #endif
        [IsoXmlTag("TtlNbOfTxs")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? TotalNumberOfTransactions { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? TotalNumberOfTransactions { get; init; } 
        #else
        public System.UInt64? TotalNumberOfTransactions { get; set; } 
        #endif
        
        /// <summary>
        /// Details of derivatives submitted for reconciliation per counterparty pair.
        /// </summary>
        [IsoId("_cHFOd1ovEe23K4GXSpBSeg")]
        [DisplayName("Transaction Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxDtls")]
        #endif
        [IsoXmlTag("TxDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReconciliationCounterpartyPairStatistics6? TransactionDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReconciliationCounterpartyPairStatistics6? TransactionDetails { get; init; } 
        #else
        public ReconciliationCounterpartyPairStatistics6? TransactionDetails { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
