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
    /// Choice between the different statuses of a movement.
    /// </summary>
    [KnownType(typeof(CorporateActionMovementStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(CorporateActionMovementStatus1Choice.FailedStatus))]
    [KnownType(typeof(CorporateActionMovementStatus1Choice.RejectedStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionMovementStatus1Choice.ProcessedStatus),nameof(CorporateActionMovementStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(CorporateActionMovementStatus1Choice.FailedStatus),nameof(CorporateActionMovementStatus1Choice.FailedStatus))]
    [JsonDerivedType(typeof(CorporateActionMovementStatus1Choice.RejectedStatus),nameof(CorporateActionMovementStatus1Choice.RejectedStatus))]
    #endif
    [IsoId("_RiPM1dp-Ed-ak6NoX_4Aeg_-2034263409")]
    [DisplayName("Corporate Action Movement Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionMovementStatus1Choice_
    #else
    public abstract partial class CorporateActionMovementStatus1Choice_
    #endif
    {
    }
}
