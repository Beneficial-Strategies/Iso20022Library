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
namespace BeneficialStrategies.Iso20022.Choices.PreviousYear1Choice
{
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_3fxSc0XfEeGY6MkiuzuPOA_1191226349")]
    [DisplayName("Specific Previous Years")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SpecificPreviousYears : PreviousYear1Choice_
    #else
    public partial class SpecificPreviousYears : PreviousYear1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SpecificPreviousYears instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SpecificPreviousYears( System.UInt16 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Year represented by YYYY (ISO 8601).
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SpcfcPrvsYrs")]
        #endif
        [IsoXmlTag("SpcfcPrvsYrs")]
        [IsoSimpleType(IsoSimpleType.ISOYear)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISOYear Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt16 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt16 Value { get; init; } 
        #else
        public System.UInt16 Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
