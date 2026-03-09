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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification36Choice
{
    /// <summary>
    /// Identification of constituents for a basket of indexes.
    /// </summary>
    [IsoId("_POTEp4rpEeq91phomTRDDA")]
    [DisplayName("Basket")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Basket : SecurityIdentification36Choice_
    #else
    public partial class Basket : SecurityIdentification36Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Basket instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Basket( System.String reqStructurer,System.String reqIdentification )
        {
            Structurer = reqStructurer;
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the structurer of the customer basket.
        /// </summary>
        [IsoId("_lQQRIP5yEeqiEZtcZLwc3Q")]
        [DisplayName("Structurer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Strr")]
        #endif
        [IsoXmlTag("Strr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoLEIIdentifier Structurer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Structurer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Structurer { get; init; } 
        #else
        public System.String Structurer { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
        /// </summary>
        [IsoId("_EfWm0QFOEeqUa4noT3P56A")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax52Text Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Identifier of the underliers that represent the constituents of a custom basket.
        /// </summary>
        [IsoId("_HI1KgQFOEeqUa4noT3P56A")]
        [DisplayName("Constituents")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cnsttnts")]
        #endif
        [IsoXmlTag("Cnsttnts")]
        public ValueList<BasketConstituents1> Constituents { get; init; } = new ValueList<BasketConstituents1>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _HI1KgQFOEeqUa4noT3P56A
        
        
        #nullable disable
        
    }
}
