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
    /// Provides the collateral status of an instruction.
    /// </summary>
    [KnownType(typeof(CollateralStatus3Choice.Pending))]
    [KnownType(typeof(CollateralStatus3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralStatus3Choice.Pending),nameof(CollateralStatus3Choice.Pending))]
    [JsonDerivedType(typeof(CollateralStatus3Choice.Proprietary),nameof(CollateralStatus3Choice.Proprietary))]
    #endif
    [IsoId("_K3a_kOCdEei2UYJ62ws-Fw")]
    [DisplayName("Collateral Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralStatus3Choice_
    #else
    public abstract partial class CollateralStatus3Choice_
    #endif
    {
    }
}
