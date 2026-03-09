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
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.ModifiedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.NewRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.TerminatedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.CancelledRecord))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.ModifiedRecord),nameof(SecuritiesReferenceDeltaStatusReport5Choice.ModifiedRecord))]
    [JsonDerivedType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.NewRecord),nameof(SecuritiesReferenceDeltaStatusReport5Choice.NewRecord))]
    [JsonDerivedType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.TerminatedRecord),nameof(SecuritiesReferenceDeltaStatusReport5Choice.TerminatedRecord))]
    [JsonDerivedType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.CancelledRecord),nameof(SecuritiesReferenceDeltaStatusReport5Choice.CancelledRecord))]
    #endif
    [IsoId("_ozgJwaWvEeqZmriXpMtonA")]
    [DisplayName("Securities Reference Delta Status Report 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesReferenceDeltaStatusReport5Choice_
    #else
    public abstract partial class SecuritiesReferenceDeltaStatusReport5Choice_
    #endif
    {
    }
}
