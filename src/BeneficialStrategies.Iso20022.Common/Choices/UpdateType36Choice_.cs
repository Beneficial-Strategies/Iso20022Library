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
    /// Choice between action to request on a security.
    /// </summary>
    [KnownType(typeof(UpdateType36Choice.UpdateType))]
    [KnownType(typeof(UpdateType36Choice.Replace))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType36Choice.UpdateType),nameof(UpdateType36Choice.UpdateType))]
    [JsonDerivedType(typeof(UpdateType36Choice.Replace),nameof(UpdateType36Choice.Replace))]
    #endif
    [IsoId("_QGUHDZJKEeuAlLVx8pyt3w")]
    [DisplayName("Update Type 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType36Choice_
    #else
    public abstract partial class UpdateType36Choice_
    #endif
    {
    }
}
