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
namespace BeneficialStrategies.Iso20022.Choices.CommodityDerivative2Choice
{
    /// <summary>
    /// Details specific to freight derivatives.
    /// </summary>
    [IsoId("_njM5UU-nEeiVsYLJl6hleg")]
    [DisplayName("Freight")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Freight : CommodityDerivative2Choice_
    #else
    public partial class Freight : CommodityDerivative2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Freight instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Freight( System.String reqSize,System.String reqAverageTimeCharter )
        {
            Size = reqSize;
            AverageTimeCharter = reqAverageTimeCharter;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specification of the size related to the freight sub type. Field to be populated when the base product field is equal to freight.
        /// </summary>
        [IsoId("_nsafsU-nEeiVsYLJl6hleg")]
        [DisplayName("Size")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sz")]
        #endif
        [IsoXmlTag("Sz")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax25Text Size { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Size { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Size { get; init; } 
        #else
        public System.String Size { get; set; } 
        #endif
        
        /// <summary>
        /// Details the specific route or time charter average. Field to be populated when the base product field is equal to freight.
        /// </summary>
        [IsoId("_nsafs0-nEeiVsYLJl6hleg")]
        [DisplayName("Average Time Charter")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AvrgTmChrtr")]
        #endif
        [IsoXmlTag("AvrgTmChrtr")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax25Text AverageTimeCharter { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String AverageTimeCharter { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String AverageTimeCharter { get; init; } 
        #else
        public System.String AverageTimeCharter { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
