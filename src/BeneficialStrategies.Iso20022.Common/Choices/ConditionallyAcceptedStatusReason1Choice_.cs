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
    /// Conditionally accepted status reason.
    /// </summary>
    [KnownType(typeof(ConditionallyAcceptedStatusReason1Choice.Reason))]
    [KnownType(typeof(ConditionallyAcceptedStatusReason1Choice.Proprietary))]
    [KnownType(typeof(ConditionallyAcceptedStatusReason1Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason1Choice.Reason),nameof(ConditionallyAcceptedStatusReason1Choice.Reason))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason1Choice.Proprietary),nameof(ConditionallyAcceptedStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatusReason1Choice.NoSpecifiedReason),nameof(ConditionallyAcceptedStatusReason1Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_RgmOENp-Ed-ak6NoX_4Aeg_-317806410")]
    [DisplayName("Conditionally Accepted Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConditionallyAcceptedStatusReason1Choice_
    #else
    public abstract partial class ConditionallyAcceptedStatusReason1Choice_
    #endif
    {
    }
}
