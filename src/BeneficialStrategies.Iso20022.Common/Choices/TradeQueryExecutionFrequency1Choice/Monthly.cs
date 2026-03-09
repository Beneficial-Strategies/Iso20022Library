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
namespace BeneficialStrategies.Iso20022.Choices.TradeQueryExecutionFrequency1Choice
{
    /// <summary>
    /// Query is executed on a monthly basis. The day of the month of the query execution should be specified.
    /// </summary>
    [IsoId("_mmTLsNGYEeaQk737TH1Fzw")]
    [DisplayName("Monthly")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Monthly : TradeQueryExecutionFrequency1Choice_
    #else
    public partial class Monthly : TradeQueryExecutionFrequency1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Monthly instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Monthly( System.UInt64 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number (max 999) of objects represented as an integer.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Mnthly")]
        #endif
        [IsoXmlTag("Mnthly")]
        [IsoSimpleType(IsoSimpleType.Max3Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax3Number Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Value { get; init; } 
        #else
        public System.UInt64 Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
