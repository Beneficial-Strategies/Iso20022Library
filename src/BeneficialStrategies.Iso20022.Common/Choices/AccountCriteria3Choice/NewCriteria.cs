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
namespace BeneficialStrategies.Iso20022.Choices.AccountCriteria3Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_PxA_lW49EeiU9cctagi5ow")]
    [DisplayName("New Criteria")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NewCriteria : AccountCriteria3Choice_
    #else
    public partial class NewCriteria : AccountCriteria3Choice_
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
        [IsoId("_P8Cj0249EeiU9cctagi5ow")]
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
        /// Defines the criteria to be used to extract the account information.
        /// </summary>
        [IsoId("_P8Cj1W49EeiU9cctagi5ow")]
        [DisplayName("Search Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SchCrit")]
        #endif
        [IsoXmlTag("SchCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccountSearchCriteria7? SearchCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccountSearchCriteria7? SearchCriteria { get; init; } 
        #else
        public CashAccountSearchCriteria7? SearchCriteria { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the expected account report.
        /// </summary>
        [IsoId("_P8Cj1249EeiU9cctagi5ow")]
        [DisplayName("Return Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RtrCrit")]
        #endif
        [IsoXmlTag("RtrCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccountReturnCriteria5? ReturnCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccountReturnCriteria5? ReturnCriteria { get; init; } 
        #else
        public CashAccountReturnCriteria5? ReturnCriteria { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
