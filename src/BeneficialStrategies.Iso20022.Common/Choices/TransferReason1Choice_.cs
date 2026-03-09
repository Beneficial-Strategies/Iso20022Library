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
    /// Choice between formats for a transfer reason.
    /// </summary>
    [KnownType(typeof(TransferReason1Choice.Code))]
    [KnownType(typeof(TransferReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransferReason1Choice.Code),nameof(TransferReason1Choice.Code))]
    [JsonDerivedType(typeof(TransferReason1Choice.Proprietary),nameof(TransferReason1Choice.Proprietary))]
    #endif
    [IsoId("_hPw_oa51EeeMy7TnJ3e__g")]
    [DisplayName("Transfer Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferReason1Choice_
    #else
    public abstract partial class TransferReason1Choice_
    #endif
    {
    }
}
