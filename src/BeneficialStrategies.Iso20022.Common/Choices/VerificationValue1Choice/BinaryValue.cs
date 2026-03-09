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
namespace BeneficialStrategies.Iso20022.Choices.VerificationValue1Choice
{
    /// <summary>
    /// Value of the data expressed in BASE-64 encoded binary form.
    /// </summary>
    [IsoId("_4EhKp5aNEemfCcEf5rVTyg")]
    [DisplayName("Binary Value")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BinaryValue : VerificationValue1Choice_
    #else
    public partial class BinaryValue : VerificationValue1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BinaryValue instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BinaryValue( System.Byte[] reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a binary string with a maximum length of 5000 binary bytes.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BinryVal")]
        #endif
        [IsoXmlTag("BinryVal")]
        [IsoSimpleType(IsoSimpleType.Max5000Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax5000Binary Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Byte[] Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[] Value { get; init; } 
        #else
        public System.Byte[] Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
