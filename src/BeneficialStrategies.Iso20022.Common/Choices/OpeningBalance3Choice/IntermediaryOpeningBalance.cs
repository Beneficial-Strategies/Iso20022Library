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
namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance3Choice
{
    /// <summary>
    /// Opening balance of this page only. It must be the intermediary closing balance of the previous page (part of the same statement).
    /// </summary>
    [IsoId("_Szn0AQgHEeSxsfb1OEDVsw")]
    [DisplayName("Intermediary Opening Balance")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IntermediaryOpeningBalance : OpeningBalance3Choice_
    #else
    public partial class IntermediaryOpeningBalance : OpeningBalance3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IntermediaryOpeningBalance instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IntermediaryOpeningBalance( System.UInt64 reqUnit )
        {
            Unit = reqUnit;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Quantity expressed as a number, eg, a number of shares.
        /// </summary>
        [IsoId("_SoH21dp-Ed-ak6NoX_4Aeg_-1748202212")]
        [DisplayName("Unit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Unit")]
        #endif
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber Unit { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Unit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Unit { get; init; } 
        #else
        public System.UInt64 Unit { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
