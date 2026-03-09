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
namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery4Choice
{
    /// <summary>
    /// Query criteria specifically applied to recurrent queries.
    /// </summary>
    [IsoId("_QH0wc4eAEei-Poi-FosJdw")]
    [DisplayName("Recurrent Query")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RecurrentQuery : TradeReportQuery4Choice_
    #else
    public partial class RecurrentQuery : TradeReportQuery4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RecurrentQuery instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RecurrentQuery( System.String reqQueryType,TradeQueryExecutionFrequency1Choice_ reqFrequency,System.DateOnly reqValidUntil )
        {
            QueryType = reqQueryType;
            Frequency = reqFrequency;
            ValidUntil = reqValidUntil;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Defines the type of recurrent query which is requested.
        /// </summary>
        [IsoId("_QV1XQYeAEei-Poi-FosJdw")]
        [DisplayName("Query Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QryTp")]
        #endif
        [IsoXmlTag("QryTp")]
        [IsoSimpleType(IsoSimpleType.Max1000Text)]
        [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax1000Text QueryType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String QueryType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String QueryType { get; init; } 
        #else
        public System.String QueryType { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the requested frequency of the recurrent query.
        /// </summary>
        [IsoId("_QV1XQ4eAEei-Poi-FosJdw")]
        [DisplayName("Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Frqcy")]
        #endif
        [IsoXmlTag("Frqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TradeQueryExecutionFrequency1Choice_ Frequency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TradeQueryExecutionFrequency1Choice_ Frequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeQueryExecutionFrequency1Choice_ Frequency { get; init; } 
        #else
        public TradeQueryExecutionFrequency1Choice_ Frequency { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the date until which the query will be executed.
        /// </summary>
        [IsoId("_QV1XRYeAEei-Poi-FosJdw")]
        [DisplayName("Valid Until")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldUntil")]
        #endif
        [IsoXmlTag("VldUntil")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ValidUntil { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly ValidUntil { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ValidUntil { get; init; } 
        #else
        public System.DateOnly ValidUntil { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
