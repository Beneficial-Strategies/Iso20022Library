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
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus1Choice.NoSpecifiedReason),nameof(RejectedStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus1Choice.Reason),nameof(RejectedStatus1Choice.Reason))]
    #endif
    [IsoId("_QyjcVNp-Ed-ak6NoX_4Aeg_-600470568")]
    [DisplayName("Rejected Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus1Choice_
    #else
    public abstract partial class RejectedStatus1Choice_
    #endif
    {
    }
}
