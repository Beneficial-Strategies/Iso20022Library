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
    /// Provides the collateral details for the secured markets.
    /// </summary>
    [KnownType(typeof(SecuredCollateral2Choice.SingleCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.MultipleCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.PoolCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.OtherCollateral))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuredCollateral2Choice.SingleCollateral),nameof(SecuredCollateral2Choice.SingleCollateral))]
    [JsonDerivedType(typeof(SecuredCollateral2Choice.MultipleCollateral),nameof(SecuredCollateral2Choice.MultipleCollateral))]
    [JsonDerivedType(typeof(SecuredCollateral2Choice.PoolCollateral),nameof(SecuredCollateral2Choice.PoolCollateral))]
    [JsonDerivedType(typeof(SecuredCollateral2Choice.OtherCollateral),nameof(SecuredCollateral2Choice.OtherCollateral))]
    #endif
    [IsoId("_h6SUN6idEeWHO_l3hf2rlA")]
    [DisplayName("Secured Collateral 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuredCollateral2Choice_
    #else
    public abstract partial class SecuredCollateral2Choice_
    #endif
    {
    }
}
