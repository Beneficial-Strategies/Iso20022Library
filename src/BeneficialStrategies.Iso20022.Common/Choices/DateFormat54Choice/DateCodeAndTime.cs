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
namespace BeneficialStrategies.Iso20022.Choices.DateFormat54Choice
{
    /// <summary>
    /// Specifies a date code and a time.
    /// </summary>
    [IsoId("_k9m0uc3xEee5nJBZsW8MFQ")]
    [DisplayName("Date Code And Time")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DateCodeAndTime : DateFormat54Choice_
    #else
    public partial class DateCodeAndTime : DateFormat54Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DateCodeAndTime instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DateCodeAndTime( DateCode26Choice_ reqDateCode,System.TimeOnly reqTime )
        {
            DateCode = reqDateCode;
            Time = reqTime;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the type of date.
        /// </summary>
        [IsoId("_ctczCZKQEeWHWpTQn1FFVg")]
        [DisplayName("Date Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtCd")]
        #endif
        [IsoXmlTag("DtCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DateCode26Choice_ DateCode { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DateCode26Choice_ DateCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateCode26Choice_ DateCode { get; init; } 
        #else
        public DateCode26Choice_ DateCode { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the time.
        /// </summary>
        [IsoId("_ctczEZKQEeWHWpTQn1FFVg")]
        [DisplayName("Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tm")]
        #endif
        [IsoXmlTag("Tm")]
        [IsoSimpleType(IsoSimpleType.ISOTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISOTime Time { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.TimeOnly Time { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.TimeOnly Time { get; init; } 
        #else
        public System.TimeOnly Time { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
