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
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason14Choice.Code))]
    [KnownType(typeof(UnmatchedReason14Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedReason14Choice.Code),nameof(UnmatchedReason14Choice.Code))]
    [JsonDerivedType(typeof(UnmatchedReason14Choice.Proprietary),nameof(UnmatchedReason14Choice.Proprietary))]
    #endif
    [IsoId("_Nrbv0SwZEeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Reason 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason14Choice_
    #else
    public abstract partial class UnmatchedReason14Choice_
    #endif
    {
    }
}
