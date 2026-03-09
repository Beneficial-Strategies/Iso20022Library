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
namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>
    /// Lower boundary of a range of quantity values.
    /// </summary>
    [IsoId("_jtRfEO5NEeCisYr99QEiWA_-377163681")]
    [DisplayName("From Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FromQuantity : QuantityRange1Choice_
    #else
    public partial class FromQuantity : QuantityRange1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FromQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FromQuantity( System.UInt64 reqBoundary,System.String reqIncluded )
        {
            Boundary = reqBoundary;
            Included = reqIncluded;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Quantity value of the range limit.
        /// </summary>
        [IsoId("_jtapAO5NEeCisYr99QEiWA_-330775982")]
        [DisplayName("Boundary")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Bdry")]
        #endif
        [IsoXmlTag("Bdry")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber Boundary { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Boundary { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Boundary { get; init; } 
        #else
        public System.UInt64 Boundary { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the boundary quantity is included in the range of quantity values.
        /// </summary>
        [IsoId("_jtapAe5NEeCisYr99QEiWA_279625946")]
        [DisplayName("Included")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Incl")]
        #endif
        [IsoXmlTag("Incl")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoYesNoIndicator Included { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Included { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Included { get; init; } 
        #else
        public System.String Included { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
