// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
    /// </summary>
    [KnownType(typeof(CollateralMovement4Choice.CollateralMovementDirection))]
    [KnownType(typeof(CollateralMovement4Choice.Return))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralMovement4Choice.CollateralMovementDirection),nameof(CollateralMovement4Choice.CollateralMovementDirection))]
    [JsonDerivedType(typeof(CollateralMovement4Choice.Return),nameof(CollateralMovement4Choice.Return))]
    #endif
    [IsoId("_yGZ5JYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Movement 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralMovement4Choice_
    #else
    public abstract partial class CollateralMovement4Choice_
    #endif
    {
    }
}
