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
    /// Range of valid quantity values.
    /// </summary>
    [IsoId("_jtRfEu5NEeCisYr99QEiWA_-1639886527")]
    [DisplayName("From To Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FromToQuantity : QuantityRange1Choice_
    #else
    public partial class FromToQuantity : QuantityRange1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FromToQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FromToQuantity( QuantityRangeBoundary1 reqFromQuantity,QuantityRangeBoundary1 reqToQuantity )
        {
            FromQuantity = reqFromQuantity;
            ToQuantity = reqToQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Lower boundary of a range of quantity values.
        /// </summary>
        [IsoId("_jtHuEu5NEeCisYr99QEiWA_-621671182")]
        [DisplayName("From Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrQty")]
        #endif
        [IsoXmlTag("FrQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required QuantityRangeBoundary1 FromQuantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required QuantityRangeBoundary1 FromQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public QuantityRangeBoundary1 FromQuantity { get; init; } 
        #else
        public QuantityRangeBoundary1 FromQuantity { get; set; } 
        #endif
        
        /// <summary>
        /// Upper boundary of a range of quantity values.
        /// </summary>
        [IsoId("_jtHuE-5NEeCisYr99QEiWA_788676247")]
        [DisplayName("To Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ToQty")]
        #endif
        [IsoXmlTag("ToQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required QuantityRangeBoundary1 ToQuantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required QuantityRangeBoundary1 ToQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public QuantityRangeBoundary1 ToQuantity { get; init; } 
        #else
        public QuantityRangeBoundary1 ToQuantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
