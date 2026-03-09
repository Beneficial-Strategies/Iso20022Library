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
namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification4Choice
{
    /// <summary>
    /// Identification of the payment instruction by its position in a queue managed by the clearing agent.
    /// </summary>
    [IsoId("_74w4oaMgEeCJ6YNENx4h-w_1971308205")]
    [DisplayName("Queue Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record QueueIdentification : PaymentIdentification4Choice_
    #else
    public partial class QueueIdentification : PaymentIdentification4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a QueueIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public QueueIdentification( System.String reqValue,System.String reqPositionInQueue )
        {
            Value = reqValue;
            PositionInQueue = reqPositionInQueue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the payment queue where the payment instruction resides.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QId")]
        #endif
        [IsoXmlTag("QId")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax16Text Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        /// <summary>
        /// Position of the payment instruction within the identified queue.
        /// </summary>
        [IsoId("_Rb1C1dp-Ed-ak6NoX_4Aeg_1491461464")]
        [DisplayName("Position In Queue")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PosInQ")]
        #endif
        [IsoXmlTag("PosInQ")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax16Text PositionInQueue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String PositionInQueue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String PositionInQueue { get; init; } 
        #else
        public System.String PositionInQueue { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
