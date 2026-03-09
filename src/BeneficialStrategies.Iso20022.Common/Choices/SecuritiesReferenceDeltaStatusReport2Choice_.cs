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
    /// Choice defining financial instruments that are either new or have been modified.
    /// </summary>
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.ModifiedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.NewRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.TerminatedRecord))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.ModifiedRecord),nameof(SecuritiesReferenceDeltaStatusReport2Choice.ModifiedRecord))]
    [JsonDerivedType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.NewRecord),nameof(SecuritiesReferenceDeltaStatusReport2Choice.NewRecord))]
    [JsonDerivedType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.TerminatedRecord),nameof(SecuritiesReferenceDeltaStatusReport2Choice.TerminatedRecord))]
    #endif
    [IsoId("_2XCW1Hv0EeanCNPcMT7sSg")]
    [DisplayName("Securities Reference Delta Status Report 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesReferenceDeltaStatusReport2Choice_
    #else
    public abstract partial class SecuritiesReferenceDeltaStatusReport2Choice_
    #endif
    {
    }
}
