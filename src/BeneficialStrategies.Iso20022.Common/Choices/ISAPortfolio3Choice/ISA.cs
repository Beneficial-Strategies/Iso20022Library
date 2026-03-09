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
namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio3Choice
{
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. 
    /// The Individual Savings Account (ISA) is provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_L26-t_sqEeCXvelB0HU7AQ")]
    [DisplayName("ISA")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ISA : ISAPortfolio3Choice_
    #else
    public partial class ISA : ISAPortfolio3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// ISA that was issued during the current fiscal year.
        /// </summary>
        [IsoId("_3gqDQEXfEeGY6MkiuzuPOA_-1966733702")]
        [DisplayName("Current Year")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurYr")]
        #endif
        [IsoXmlTag("CurYr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CurrentYearType2Choice_? CurrentYear { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CurrentYearType2Choice_? CurrentYear { get; init; } 
        #else
        public CurrentYearType2Choice_? CurrentYear { get; set; } 
        #endif
        
        /// <summary>
        /// Selection of investment plans issued during previous years.
        /// </summary>
        [IsoId("_3gqDQUXfEeGY6MkiuzuPOA_334088888")]
        [DisplayName("Previous Years")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrvsYrs")]
        #endif
        [IsoXmlTag("PrvsYrs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PreviousYearChoice_? PreviousYears { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PreviousYearChoice_? PreviousYears { get; init; } 
        #else
        public PreviousYearChoice_? PreviousYears { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
