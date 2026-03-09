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
namespace BeneficialStrategies.Iso20022.Choices.TransactionCriteria7Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_-S2D0wKxEe2rHs6fbn9-0A")]
    [DisplayName("New Criteria")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NewCriteria : TransactionCriteria7Choice_
    #else
    public partial class NewCriteria : TransactionCriteria7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_-9kb0wKxEe2rHs6fbn9-0A")]
        [DisplayName("New Query Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NewQryNm")]
        #endif
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? NewQueryName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? NewQueryName { get; init; } 
        #else
        public System.String? NewQueryName { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the criteria on which the information is extracted.
        /// </summary>
        [IsoId("_-9kb1QKxEe2rHs6fbn9-0A")]
        [DisplayName("Search Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SchCrit")]
        #endif
        [IsoXmlTag("SchCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionSearchCriteria10? SearchCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionSearchCriteria10? SearchCriteria { get; init; } 
        #else
        public TransactionSearchCriteria10? SearchCriteria { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the format of the requested report.
        /// </summary>
        [IsoId("_-9kb1wKxEe2rHs6fbn9-0A")]
        [DisplayName("Statement Report")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StmtRpt")]
        #endif
        [IsoXmlTag("StmtRpt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReportIndicator1Code? StatementReport { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReportIndicator1Code? StatementReport { get; init; } 
        #else
        public ReportIndicator1Code? StatementReport { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the expected payment transaction report.
        /// </summary>
        [IsoId("_-9kb2QKxEe2rHs6fbn9-0A")]
        [DisplayName("Return Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RtrCrit")]
        #endif
        [IsoXmlTag("RtrCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionReturnCriteria5? ReturnCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionReturnCriteria5? ReturnCriteria { get; init; } 
        #else
        public TransactionReturnCriteria5? ReturnCriteria { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
