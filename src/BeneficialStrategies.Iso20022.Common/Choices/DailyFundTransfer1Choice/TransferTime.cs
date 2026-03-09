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
namespace BeneficialStrategies.Iso20022.Choices.DailyFundTransfer1Choice
{
    /// <summary>
    /// Time daily balances are transferred.
    /// </summary>
    [IsoId("_K4zysCc7Eea7avjfd7yDAA")]
    [DisplayName("Transfer Time")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TransferTime : DailyFundTransfer1Choice_
    #else
    public partial class TransferTime : DailyFundTransfer1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TransferTime instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TransferTime( System.TimeOnly reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time in a calendar day expressed in either UTC time format (hh:mm:ss.sssZ), local time with UTC offset format (hh:mm:ss.sss+/-hh:mm), or local time format (hh:mm:ss.sss). These representations are defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.|Note on the time format:|1) beginning / end of calendar day|00:00:00 = the beginning of a calendar day|24:00:00 = the end of a calendar day|2) fractions of second in time format|Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfTm")]
        #endif
        [IsoXmlTag("TrfTm")]
        [IsoSimpleType(IsoSimpleType.ISOTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISOTime Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.TimeOnly Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.TimeOnly Value { get; init; } 
        #else
        public System.TimeOnly Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
