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
namespace BeneficialStrategies.Iso20022.Choices.CommodityDerivate2Choice
{
    /// <summary>
    /// Details specific to energy derivatives.
    /// </summary>
    [IsoId("_zwLKw2lHEeaLAKoEUNsD9g")]
    [DisplayName("Energy")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Energy : CommodityDerivate2Choice_
    #else
    public partial class Energy : CommodityDerivate2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Energy instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Energy( System.String reqSettlementLocation )
        {
            SettlementLocation = reqSettlementLocation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Place where the delivery and the cash settlement of the base product occurs.
        /// </summary>
        [IsoId("_fDBVYX5zEeasY4u9QTizPQ")]
        [DisplayName("Settlement Location")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmLctn")]
        #endif
        [IsoXmlTag("SttlmLctn")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax25Text SettlementLocation { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String SettlementLocation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SettlementLocation { get; init; } 
        #else
        public System.String SettlementLocation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
