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
namespace BeneficialStrategies.Iso20022.Choices.AssetClassAttributes1Choice
{
    /// <summary>
    /// Asset class is composed of both an interest derivate and a foreign exchange derivative.
    /// </summary>
    [IsoId("_vAX4UO94EeW7gabYEJmWIA")]
    [DisplayName("Both")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Both : AssetClassAttributes1Choice_
    #else
    public partial class Both : AssetClassAttributes1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Both instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Both( DerivativeInterest2 reqInterest,DerivativeForeignExchange2 reqForeignExchange )
        {
            Interest = reqInterest;
            ForeignExchange = reqForeignExchange;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Asset class is a non-financial instrument of type interest rate.
        /// </summary>
        [IsoId("_IO1OE8nYEeWpf-ImB_F2gQ")]
        [DisplayName("Interest")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Intrst")]
        #endif
        [IsoXmlTag("Intrst")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DerivativeInterest2 Interest { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DerivativeInterest2 Interest { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DerivativeInterest2 Interest { get; init; } 
        #else
        public DerivativeInterest2 Interest { get; set; } 
        #endif
        
        /// <summary>
        /// Asset class is a non-financial instrument of type foreign exchange.
        /// </summary>
        [IsoId("_IO1OFcnYEeWpf-ImB_F2gQ")]
        [DisplayName("Foreign Exchange")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FX")]
        #endif
        [IsoXmlTag("FX")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DerivativeForeignExchange2 ForeignExchange { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DerivativeForeignExchange2 ForeignExchange { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DerivativeForeignExchange2 ForeignExchange { get; init; } 
        #else
        public DerivativeForeignExchange2 ForeignExchange { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
