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
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation8Choice.References))]
    [KnownType(typeof(Cancellation8Choice.TransferOutDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation8Choice.References),nameof(Cancellation8Choice.References))]
    [JsonDerivedType(typeof(Cancellation8Choice.TransferOutDetails),nameof(Cancellation8Choice.TransferOutDetails))]
    #endif
    [IsoId("_gwr8oT8BEeSIqOPJHpnleA")]
    [DisplayName("Cancellation 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation8Choice_
    #else
    public abstract partial class Cancellation8Choice_
    #endif
    {
    }
}
