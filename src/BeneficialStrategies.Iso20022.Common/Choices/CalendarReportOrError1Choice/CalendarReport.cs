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
namespace BeneficialStrategies.Iso20022.Choices.CalendarReportOrError1Choice
{
    /// <summary>
    /// Provides the calendar information related to the system.
    /// </summary>
    [IsoId("_dVcQ44m7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CalendarReport : CalendarReportOrError1Choice_
    #else
    public partial class CalendarReport : CalendarReportOrError1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CalendarReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CalendarReport( CalendarOrBusinessError1Choice_ reqCalendarOrError )
        {
            CalendarOrError = reqCalendarOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the service or system for which the calendar information is provided.
        /// </summary>
        [IsoId("_G00uIYm8Eeipw6hHPgB4Sw")]
        [DisplayName("Service")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Svc")]
        #endif
        [IsoXmlTag("Svc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemAndCurrency1? Service { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemAndCurrency1? Service { get; init; } 
        #else
        public SystemAndCurrency1? Service { get; set; } 
        #endif
        
        /// <summary>
        /// Requested information on the calendar or business error report when information has not been found.
        /// </summary>
        [IsoId("_dVcQ34m7Eeipw6hHPgB4Sw")]
        [DisplayName("Calendar Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CalOrErr")]
        #endif
        [IsoXmlTag("CalOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CalendarOrBusinessError1Choice_ CalendarOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CalendarOrBusinessError1Choice_ CalendarOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CalendarOrBusinessError1Choice_ CalendarOrError { get; init; } 
        #else
        public CalendarOrBusinessError1Choice_ CalendarOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
