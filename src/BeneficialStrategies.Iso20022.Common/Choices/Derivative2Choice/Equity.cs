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
namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice
{
    /// <summary>
    /// Details specific for Equity derivatives.
    /// </summary>
    [IsoId("_Bv9MR2kwEeaLAKoEUNsD9g")]
    [DisplayName("Equity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Equity : Derivative2Choice_
    #else
    public partial class Equity : Derivative2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Equity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Equity( EquityDerivative3Choice_ reqUnderlyingType )
        {
            UnderlyingType = reqUnderlyingType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Underlying type of the equity derivative.
        /// </summary>
        [IsoId("_PeXW0WlNEeaLAKoEUNsD9g")]
        [DisplayName("Underlying Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygTp")]
        #endif
        [IsoXmlTag("UndrlygTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required EquityDerivative3Choice_ UnderlyingType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required EquityDerivative3Choice_ UnderlyingType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public EquityDerivative3Choice_ UnderlyingType { get; init; } 
        #else
        public EquityDerivative3Choice_ UnderlyingType { get; set; } 
        #endif
        
        /// <summary>
        /// Return parameter for the equity derivative.
        /// </summary>
        [IsoId("_PeXW02lNEeaLAKoEUNsD9g")]
        [DisplayName("Parameter")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Param")]
        #endif
        [IsoXmlTag("Param")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public EquityReturnParameter1Code? Parameter { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public EquityReturnParameter1Code? Parameter { get; init; } 
        #else
        public EquityReturnParameter1Code? Parameter { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
