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
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal4Choice
{
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_xv7544FvEeWtPe6Crjmeug")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SegregatedIndependentAmount : CollateralProposal4Choice_
    #else
    public partial class SegregatedIndependentAmount : CollateralProposal4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SegregatedIndependentAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SegregatedIndependentAmount( ActiveCurrencyAndAmount reqAgreedAmount )
        {
            AgreedAmount = reqAgreedAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the call amount that is agreed and that will result in a collateral movement.
        /// </summary>
        [IsoId("_yGZ5IYFvEeWtPe6Crjmeug")]
        [DisplayName("Agreed Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AgrdAmt")]
        #endif
        [IsoXmlTag("AgrdAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount AgreedAmount { get; init; } 
        #else
        public ActiveCurrencyAndAmount AgreedAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
        /// </summary>
        [IsoId("_yGZ5I4FvEeWtPe6Crjmeug")]
        [DisplayName("Movement Direction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MvmntDrctn")]
        #endif
        [IsoXmlTag("MvmntDrctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralMovement4Choice_? MovementDirection { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralMovement4Choice_? MovementDirection { get; init; } 
        #else
        public CollateralMovement4Choice_? MovementDirection { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
