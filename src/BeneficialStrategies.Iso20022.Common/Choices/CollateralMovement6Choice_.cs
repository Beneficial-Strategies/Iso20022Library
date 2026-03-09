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
    /// Provides the collateral movement direction that is a delivery and optionally a return, or a return only.
    /// </summary>
    [KnownType(typeof(CollateralMovement6Choice.CollateralMovementDirection))]
    [KnownType(typeof(CollateralMovement6Choice.Return))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralMovement6Choice.CollateralMovementDirection),nameof(CollateralMovement6Choice.CollateralMovementDirection))]
    [JsonDerivedType(typeof(CollateralMovement6Choice.Return),nameof(CollateralMovement6Choice.Return))]
    #endif
    [IsoId("_6IUJJSqREeyR9JrVGfaMKw")]
    [DisplayName("Collateral Movement 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralMovement6Choice_
    #else
    public abstract partial class CollateralMovement6Choice_
    #endif
    {
    }
}
