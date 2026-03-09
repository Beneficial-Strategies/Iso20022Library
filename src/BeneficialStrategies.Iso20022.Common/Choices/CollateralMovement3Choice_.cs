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
    [KnownType(typeof(CollateralMovement3Choice.CollateralMovementDirection))]
    [KnownType(typeof(CollateralMovement3Choice.Return))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralMovement3Choice.CollateralMovementDirection),nameof(CollateralMovement3Choice.CollateralMovementDirection))]
    [JsonDerivedType(typeof(CollateralMovement3Choice.Return),nameof(CollateralMovement3Choice.Return))]
    #endif
    [IsoId("_QQNJlV9-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Movement 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralMovement3Choice_
    #else
    public abstract partial class CollateralMovement3Choice_
    #endif
    {
    }
}
