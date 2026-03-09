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
    /// Choice of format for the update information.
    /// </summary>
    [KnownType(typeof(UpdateType15Choice.Code))]
    [KnownType(typeof(UpdateType15Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType15Choice.Code),nameof(UpdateType15Choice.Code))]
    [JsonDerivedType(typeof(UpdateType15Choice.Proprietary),nameof(UpdateType15Choice.Proprietary))]
    #endif
    [IsoId("_XMoFcTeQEeWm5uvLSn0jEw")]
    [DisplayName("Update Type 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType15Choice_
    #else
    public abstract partial class UpdateType15Choice_
    #endif
    {
    }
}
