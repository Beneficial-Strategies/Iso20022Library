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
namespace BeneficialStrategies.Iso20022.Choices.FixedOrRecurrentDate1Choice
{
    /// <summary>
    /// Details related to recurrent dates on which the variation is triggered.
    /// </summary>
    [IsoId("_98U8AXltEeG7BsjMvd1mEw_-1677013285")]
    [DisplayName("Recurrent Date")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RecurrentDate : FixedOrRecurrentDate1Choice_
    #else
    public partial class RecurrentDate : FixedOrRecurrentDate1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RecurrentDate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RecurrentDate( System.DateOnly reqStartDate,ExternalDateFrequency1Code reqFrequency,System.UInt64 reqNumber )
        {
            StartDate = reqStartDate;
            Frequency = reqFrequency;
            Number = reqNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Date on which a recurrent date will commence.
        /// </summary>
        [IsoId("_98LLA3ltEeG7BsjMvd1mEw_-900960723")]
        [DisplayName("Start Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StartDt")]
        #endif
        [IsoXmlTag("StartDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate StartDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly StartDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly StartDate { get; init; } 
        #else
        public System.DateOnly StartDate { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the regularity of the trigger date.
        /// </summary>
        [IsoId("_98LLBHltEeG7BsjMvd1mEw_-1516871632")]
        [DisplayName("Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Frqcy")]
        #endif
        [IsoXmlTag("Frqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalDateFrequency1Code Frequency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExternalDateFrequency1Code Frequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalDateFrequency1Code Frequency { get; init; } 
        #else
        public ExternalDateFrequency1Code Frequency { get; set; } 
        #endif
        
        /// <summary>
        /// Maximum number of trigger date occurrence cycles.
        /// </summary>
        [IsoId("_98LLBXltEeG7BsjMvd1mEw_-1181408529")]
        [DisplayName("Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nb")]
        #endif
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber Number { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Number { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Number { get; init; } 
        #else
        public System.UInt64 Number { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
