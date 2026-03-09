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
namespace BeneficialStrategies.Iso20022.Choices.SortCriteria1Choice
{
    /// <summary>
    /// Pre-defined way of indicating how the information is broken down.
    /// </summary>
    [IsoId("_U1-1hdp-Ed-ak6NoX_4Aeg_1036248630")]
    [DisplayName("Predefined")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Predefined : SortCriteria1Choice_
    #else
    public partial class Predefined : SortCriteria1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Predefined instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Predefined( ReportSortedType1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of criterion used to sort a report.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Prdfnd")]
        #endif
        [IsoXmlTag("Prdfnd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReportSortedType1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReportSortedType1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReportSortedType1Code Value { get; init; } 
        #else
        public ReportSortedType1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
