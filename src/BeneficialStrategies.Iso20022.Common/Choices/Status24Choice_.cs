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
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status24Choice.OrderDetailsReport))]
    [KnownType(typeof(Status24Choice.IndividualOrderDetailsReport))]
    [KnownType(typeof(Status24Choice.SwitchOrderDetailsReport))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status24Choice.OrderDetailsReport),nameof(Status24Choice.OrderDetailsReport))]
    [JsonDerivedType(typeof(Status24Choice.IndividualOrderDetailsReport),nameof(Status24Choice.IndividualOrderDetailsReport))]
    [JsonDerivedType(typeof(Status24Choice.SwitchOrderDetailsReport),nameof(Status24Choice.SwitchOrderDetailsReport))]
    #endif
    [IsoId("_N37HcEHPEeazV4RAqPV71g")]
    [DisplayName("Status 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status24Choice_
    #else
    public abstract partial class Status24Choice_
    #endif
    {
    }
}
