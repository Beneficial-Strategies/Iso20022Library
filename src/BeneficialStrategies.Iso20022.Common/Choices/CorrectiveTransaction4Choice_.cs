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
    /// Specifies the corrective transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(CorrectiveTransaction4Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction4Choice.Interbank))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorrectiveTransaction4Choice.Initiation),nameof(CorrectiveTransaction4Choice.Initiation))]
    [JsonDerivedType(typeof(CorrectiveTransaction4Choice.Interbank),nameof(CorrectiveTransaction4Choice.Interbank))]
    #endif
    [IsoId("_3bNYAXuSEeivKIBRHeTQRQ")]
    [DisplayName("Corrective Transaction 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorrectiveTransaction4Choice_
    #else
    public abstract partial class CorrectiveTransaction4Choice_
    #endif
    {
    }
}
