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
namespace BeneficialStrategies.Iso20022.Choices.PercentageRange1Choice
{
    /// <summary>
    /// Range of valid percentage rates.
    /// </summary>
    [IsoId("_7_LCoKMgEeCJ6YNENx4h-w_-1139827354")]
    [DisplayName("From To")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FromTo : PercentageRange1Choice_
    #else
    public partial class FromTo : PercentageRange1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FromTo instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FromTo( PercentageRangeBoundary1 reqFrom,PercentageRangeBoundary1 reqTo )
        {
            From = reqFrom;
            To = reqTo;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Lower boundary of a range of percentage rates.
        /// </summary>
        [IsoId("_7_BRpqMgEeCJ6YNENx4h-w_-455806218")]
        [DisplayName("From")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Fr")]
        #endif
        [IsoXmlTag("Fr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PercentageRangeBoundary1 From { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PercentageRangeBoundary1 From { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PercentageRangeBoundary1 From { get; init; } 
        #else
        public PercentageRangeBoundary1 From { get; set; } 
        #endif
        
        /// <summary>
        /// Upper boundary of a range of percentage rates.
        /// </summary>
        [IsoId("_7_BRp6MgEeCJ6YNENx4h-w_898182717")]
        [DisplayName("To")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="To")]
        #endif
        [IsoXmlTag("To")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PercentageRangeBoundary1 To { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PercentageRangeBoundary1 To { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PercentageRangeBoundary1 To { get; init; } 
        #else
        public PercentageRangeBoundary1 To { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
