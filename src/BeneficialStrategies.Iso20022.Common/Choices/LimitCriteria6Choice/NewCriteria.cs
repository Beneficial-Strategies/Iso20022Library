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
namespace BeneficialStrategies.Iso20022.Choices.LimitCriteria6Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_FMyWZW4-EeiU9cctagi5ow")]
    [DisplayName("New Criteria")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NewCriteria : LimitCriteria6Choice_
    #else
    public partial class NewCriteria : LimitCriteria6Choice_
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
        [IsoId("_FZ5lV24-EeiU9cctagi5ow")]
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
        /// Defines the criteria to extract the limit information.
        /// </summary>
        [IsoId("_FZ5lWW4-EeiU9cctagi5ow")]
        [DisplayName("Search Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SchCrit")]
        #endif
        [IsoXmlTag("SchCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LimitSearchCriteria6? SearchCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LimitSearchCriteria6? SearchCriteria { get; init; } 
        #else
        public LimitSearchCriteria6? SearchCriteria { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the expected limit report.
        /// </summary>
        [IsoId("_FZ5lW24-EeiU9cctagi5ow")]
        [DisplayName("Return Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RtrCrit")]
        #endif
        [IsoXmlTag("RtrCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LimitReturnCriteria2? ReturnCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LimitReturnCriteria2? ReturnCriteria { get; init; } 
        #else
        public LimitReturnCriteria2? ReturnCriteria { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
