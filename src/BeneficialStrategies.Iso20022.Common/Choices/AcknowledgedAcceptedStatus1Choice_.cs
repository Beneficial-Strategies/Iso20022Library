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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus1Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus1Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus1Choice.Reason),nameof(AcknowledgedAcceptedStatus1Choice.Reason))]
    #endif
    [IsoId("_UUvwttp-Ed-ak6NoX_4Aeg_-1170810063")]
    [DisplayName("Acknowledged Accepted Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgedAcceptedStatus1Choice_
    #else
    public abstract partial class AcknowledgedAcceptedStatus1Choice_
    #endif
    {
    }
}
