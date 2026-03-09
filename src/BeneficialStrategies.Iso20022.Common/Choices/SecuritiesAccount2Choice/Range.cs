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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccount2Choice
{
    /// <summary>
    /// Range of identifications of the securities accounts.
    /// </summary>
    [IsoId("_4H1_oeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Range")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Range : SecuritiesAccount2Choice_
    #else
    public partial class Range : SecuritiesAccount2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Range instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Range( SecuritiesAccount19 reqFrom,SecuritiesAccount19 reqTo )
        {
            From = reqFrom;
            To = reqTo;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Securities account number or code at which the range starts.
        /// </summary>
        [IsoId("_4UfUgeGBEeWCAvUNsZ5u6g")]
        [DisplayName("From")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Fr")]
        #endif
        [IsoXmlTag("Fr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesAccount19 From { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesAccount19 From { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesAccount19 From { get; init; } 
        #else
        public SecuritiesAccount19 From { get; set; } 
        #endif
        
        /// <summary>
        /// Securities account number or code at which the range ends.
        /// </summary>
        [IsoId("_4UfUg-GBEeWCAvUNsZ5u6g")]
        [DisplayName("To")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="To")]
        #endif
        [IsoXmlTag("To")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesAccount19 To { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesAccount19 To { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesAccount19 To { get; init; } 
        #else
        public SecuritiesAccount19 To { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
