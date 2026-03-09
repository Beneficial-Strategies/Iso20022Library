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
namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice
{
    /// <summary>
    /// Quantity of the goods, as proven by the certificate.
    /// </summary>
    [IsoId("_3DBVOTANEeOKib24wnHaFg")]
    [DisplayName("Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Quantity : CertifiedCharacteristics2Choice_
    #else
    public partial class Quantity : CertifiedCharacteristics2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Quantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Quantity( UnitOfMeasure3Choice_ reqUnitOfMeasure,System.UInt64 reqValue )
        {
            UnitOfMeasure = reqUnitOfMeasure;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies a unit of measure with a code or free text.
        /// </summary>
        [IsoId("_nbGTIBraEeOVR9VN6fAMUg")]
        [DisplayName("Unit Of Measure")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitOfMeasr")]
        #endif
        [IsoXmlTag("UnitOfMeasr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required UnitOfMeasure3Choice_ UnitOfMeasure { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required UnitOfMeasure3Choice_ UnitOfMeasure { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnitOfMeasure3Choice_ UnitOfMeasure { get; init; } 
        #else
        public UnitOfMeasure3Choice_ UnitOfMeasure { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
        /// </summary>
        [IsoId("_6QbP1xrZEeOVR9VN6fAMUg")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Value { get; init; } 
        #else
        public System.UInt64 Value { get; set; } 
        #endif
        
        /// <summary>
        /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
        /// </summary>
        [IsoId("_6QbP2RrZEeOVR9VN6fAMUg")]
        [DisplayName("Factor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Fctr")]
        #endif
        [IsoXmlTag("Fctr")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax15NumericText? Factor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Factor { get; init; } 
        #else
        public System.String? Factor { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
