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
    /// Specifies the status.
    /// </summary>
    [KnownType(typeof(Status5Choice.Code))]
    [KnownType(typeof(Status5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status5Choice.Code),nameof(Status5Choice.Code))]
    [JsonDerivedType(typeof(Status5Choice.Proprietary),nameof(Status5Choice.Proprietary))]
    #endif
    [IsoId("_Su5UCwEcEeCQm6a_G2yO_w_-778618996")]
    [DisplayName("Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status5Choice_
    #else
    public abstract partial class Status5Choice_
    #endif
    {
    }
}
