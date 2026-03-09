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
namespace BeneficialStrategies.Iso20022.Choices.RequestShareHeldDate1Choice
{
    /// <summary>
    /// Indicates what is the logical method to be used to determine and communicate from which date the shares have been held.
    /// </summary>
    [IsoId("_zKTRMFSTEempisJfoIfvvQ")]
    [DisplayName("Date Calculation Method")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DateCalculationMethod : RequestShareHeldDate1Choice_
    #else
    public partial class DateCalculationMethod : RequestShareHeldDate1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DateCalculationMethod instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DateCalculationMethod( DateCalculationMethod1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the calculation method to be used to determine on which dates the shares have been acquired.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtClctnMtd")]
        #endif
        [IsoXmlTag("DtClctnMtd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DateCalculationMethod1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DateCalculationMethod1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateCalculationMethod1Code Value { get; init; } 
        #else
        public DateCalculationMethod1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
