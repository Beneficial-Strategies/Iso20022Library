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
    /// Choice between the different statuses of an election amendment request.
    /// </summary>
    [KnownType(typeof(ElectionAmendmentStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(ElectionAmendmentStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ElectionAmendmentStatus1Choice.ProcessedStatus),nameof(ElectionAmendmentStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(ElectionAmendmentStatus1Choice.RejectedStatus),nameof(ElectionAmendmentStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_RiiHxdp-Ed-ak6NoX_4Aeg_1987378998")]
    [DisplayName("Election Amendment Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ElectionAmendmentStatus1Choice_
    #else
    public abstract partial class ElectionAmendmentStatus1Choice_
    #endif
    {
    }
}
