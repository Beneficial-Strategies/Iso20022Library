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
    [KnownType(typeof(CorrectiveTransaction2Choice.Initiation))]
    [KnownType(typeof(CorrectiveTransaction2Choice.Interbank))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorrectiveTransaction2Choice.Initiation),nameof(CorrectiveTransaction2Choice.Initiation))]
    [JsonDerivedType(typeof(CorrectiveTransaction2Choice.Interbank),nameof(CorrectiveTransaction2Choice.Interbank))]
    #endif
    [IsoId("_wO4VgWXqEeap-P22vGV91g")]
    [DisplayName("Corrective Transaction 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorrectiveTransaction2Choice_
    #else
    public abstract partial class CorrectiveTransaction2Choice_
    #endif
    {
    }
}
