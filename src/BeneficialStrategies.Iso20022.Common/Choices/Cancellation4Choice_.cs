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
    [KnownType(typeof(Cancellation4Choice.References))]
    [KnownType(typeof(Cancellation4Choice.TransferOutDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cancellation4Choice.References),nameof(Cancellation4Choice.References))]
    [JsonDerivedType(typeof(Cancellation4Choice.TransferOutDetails),nameof(Cancellation4Choice.TransferOutDetails))]
    #endif
    [IsoId("_d8mKoRXzEeOBE-jZfcm4KQ")]
    [DisplayName("Cancellation 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation4Choice_
    #else
    public abstract partial class Cancellation4Choice_
    #endif
    {
    }
}
