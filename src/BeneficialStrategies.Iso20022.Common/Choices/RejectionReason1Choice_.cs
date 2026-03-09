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
    /// Allows the sender of the rejection message to indicate only one rejection reason that applies to the entire rejected message.
    /// </summary>
    [KnownType(typeof(RejectionReason1Choice.GlobalRejectionReason))]
    [KnownType(typeof(RejectionReason1Choice.RejectedElement))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason1Choice.GlobalRejectionReason),nameof(RejectionReason1Choice.GlobalRejectionReason))]
    [JsonDerivedType(typeof(RejectionReason1Choice.RejectedElement),nameof(RejectionReason1Choice.RejectedElement))]
    #endif
    [IsoId("_RJ8ooNp-Ed-ak6NoX_4Aeg_891683676")]
    [DisplayName("Rejection Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason1Choice_
    #else
    public abstract partial class RejectionReason1Choice_
    #endif
    {
    }
}
