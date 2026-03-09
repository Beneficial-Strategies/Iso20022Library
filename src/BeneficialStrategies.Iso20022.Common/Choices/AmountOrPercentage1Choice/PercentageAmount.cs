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
namespace BeneficialStrategies.Iso20022.Choices.AmountOrPercentage1Choice
{
    /// <summary>
    /// Details related to an amount percentage.
    /// </summary>
    [IsoId("_986x6HltEeG7BsjMvd1mEw_-131852339")]
    [DisplayName("Percentage Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PercentageAmount : AmountOrPercentage1Choice_
    #else
    public partial class PercentageAmount : AmountOrPercentage1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PercentageAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PercentageAmount( System.Decimal reqRate,ExternalRelativeTo1Code reqRelativeTo )
        {
            Rate = reqRate;
            RelativeTo = reqRelativeTo;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Percentage of an amount.
        /// </summary>
        [IsoId("_99Ei53ltEeG7BsjMvd1mEw_-1531427799")]
        [DisplayName("Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rate")]
        #endif
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoPercentageRate Rate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal Rate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal Rate { get; init; } 
        #else
        public System.Decimal Rate { get; set; } 
        #endif
        
        /// <summary>
        /// Indication of what the percentage is relative to.
        /// </summary>
        [IsoId("_99Ei6HltEeG7BsjMvd1mEw_880195488")]
        [DisplayName("Relative To")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RltvTo")]
        #endif
        [IsoXmlTag("RltvTo")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalRelativeTo1Code RelativeTo { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExternalRelativeTo1Code RelativeTo { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalRelativeTo1Code RelativeTo { get; init; } 
        #else
        public ExternalRelativeTo1Code RelativeTo { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
