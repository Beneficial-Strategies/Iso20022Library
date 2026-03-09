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
    /// Choice of formats for the reason of an accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason7Choice.Code))]
    [KnownType(typeof(AcceptedReason7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcceptedReason7Choice.Code),nameof(AcceptedReason7Choice.Code))]
    [JsonDerivedType(typeof(AcceptedReason7Choice.Proprietary),nameof(AcceptedReason7Choice.Proprietary))]
    #endif
    [IsoId("_PFE46ljzEeOnqqBHs8Gasw")]
    [DisplayName("Accepted Reason 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedReason7Choice_
    #else
    public abstract partial class AcceptedReason7Choice_
    #endif
    {
    }
}
