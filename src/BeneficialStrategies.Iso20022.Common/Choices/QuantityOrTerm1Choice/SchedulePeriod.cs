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
namespace BeneficialStrategies.Iso20022.Choices.QuantityOrTerm1Choice
{
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in non-monetary amounts with a notional quantity varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_fbqi0SJDEe2zWP9pqvmqdw")]
    [DisplayName("Schedule Period")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SchedulePeriod : QuantityOrTerm1Choice_
    #else
    public partial class SchedulePeriod : QuantityOrTerm1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SchedulePeriod instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SchedulePeriod( System.UInt64 reqQuantity,System.DateOnly reqUnadjustedEffectiveDate )
        {
            Quantity = reqQuantity;
            UnadjustedEffectiveDate = reqUnadjustedEffectiveDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Number of units of the financial instrument, that is, the nominal value.
        /// </summary>
        [IsoId("_-ZlMgSJDEe2zWP9pqvmqdw")]
        [DisplayName("Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qty")]
        #endif
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoLongFraction19DecimalNumber Quantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Quantity { get; init; } 
        #else
        public System.UInt64 Quantity { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
        /// </summary>
        [IsoId("_Cw9ccSJEEe2zWP9pqvmqdw")]
        [DisplayName("Unit Of Measure")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitOfMeasr")]
        #endif
        [IsoXmlTag("UnitOfMeasr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
        #else
        public UnitOfMeasure8Choice_? UnitOfMeasure { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
        /// </summary>
        [IsoId("_2INzQSJDEe2zWP9pqvmqdw")]
        [DisplayName("Unadjusted Effective Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UadjstdFctvDt")]
        #endif
        [IsoXmlTag("UadjstdFctvDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate UnadjustedEffectiveDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly UnadjustedEffectiveDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly UnadjustedEffectiveDate { get; init; } 
        #else
        public System.DateOnly UnadjustedEffectiveDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the end date agreed in the derivative transaction without adjustment.
        /// </summary>
        [IsoId("_2INzQyJDEe2zWP9pqvmqdw")]
        [DisplayName("Unadjusted End Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UadjstdEndDt")]
        #endif
        [IsoXmlTag("UadjstdEndDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? UnadjustedEndDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? UnadjustedEndDate { get; init; } 
        #else
        public System.DateOnly? UnadjustedEndDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
