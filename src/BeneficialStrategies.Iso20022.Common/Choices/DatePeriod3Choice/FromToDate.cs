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
namespace BeneficialStrategies.Iso20022.Choices.DatePeriod3Choice
{
    /// <summary>
    /// Range of time between a start date and an end date.
    /// </summary>
    [IsoId("_A-Um5YwDEei289CGNqs21g")]
    [DisplayName("From To Date")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FromToDate : DatePeriod3Choice_
    #else
    public partial class FromToDate : DatePeriod3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FromToDate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FromToDate( System.DateOnly reqFromDate,System.DateOnly reqToDate )
        {
            FromDate = reqFromDate;
            ToDate = reqToDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Start date of the range.
        /// </summary>
        [IsoId("_lhvG0YaDEee8r9VKRbnJSg")]
        [DisplayName("From Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrDt")]
        #endif
        [IsoXmlTag("FrDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate FromDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly FromDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly FromDate { get; init; } 
        #else
        public System.DateOnly FromDate { get; set; } 
        #endif
        
        /// <summary>
        /// End date of the range.
        /// </summary>
        [IsoId("_lhvG04aDEee8r9VKRbnJSg")]
        [DisplayName("To Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ToDt")]
        #endif
        [IsoXmlTag("ToDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ToDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly ToDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ToDate { get; init; } 
        #else
        public System.DateOnly ToDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
