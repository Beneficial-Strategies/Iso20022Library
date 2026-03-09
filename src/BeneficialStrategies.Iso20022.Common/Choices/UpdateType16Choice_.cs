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
    [KnownType(typeof(UpdateType16Choice.Code))]
    [KnownType(typeof(UpdateType16Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType16Choice.Code),nameof(UpdateType16Choice.Code))]
    [JsonDerivedType(typeof(UpdateType16Choice.Proprietary),nameof(UpdateType16Choice.Proprietary))]
    #endif
    [IsoId("_cfq115KQEeWHWpTQn1FFVg")]
    [DisplayName("Update Type 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType16Choice_
    #else
    public abstract partial class UpdateType16Choice_
    #endif
    {
    }
}
