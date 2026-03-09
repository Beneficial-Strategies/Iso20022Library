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
namespace BeneficialStrategies.Iso20022.Choices.CollateralMovement5Choice
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionally a return.
    /// </summary>
    [IsoId("_sWEhcYpIEeaNTaanBSMWmg")]
    [DisplayName("Collateral Movement Direction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CollateralMovementDirection : CollateralMovement5Choice_
    #else
    public partial class CollateralMovementDirection : CollateralMovement5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CollateralMovementDirection instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CollateralMovementDirection( Collateral16 reqDeliver )
        {
            Deliver = reqDeliver;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the collateral movement direction that is a delivery only.
        /// </summary>
        [IsoId("_skpwAYpIEeaNTaanBSMWmg")]
        [DisplayName("Deliver")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dlvr")]
        #endif
        [IsoXmlTag("Dlvr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Collateral16 Deliver { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Collateral16 Deliver { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Collateral16 Deliver { get; init; } 
        #else
        public Collateral16 Deliver { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the collateral movement direction that is a return only.
        /// </summary>
        [IsoId("_skpwA4pIEeaNTaanBSMWmg")]
        [DisplayName("Return")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rtr")]
        #endif
        [IsoXmlTag("Rtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Collateral17? Return { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Collateral17? Return { get; init; } 
        #else
        public Collateral17? Return { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
