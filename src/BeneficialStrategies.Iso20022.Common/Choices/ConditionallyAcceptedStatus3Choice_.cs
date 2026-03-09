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
    /// Reason for a conditionally accepted status.
    /// </summary>
    [KnownType(typeof(ConditionallyAcceptedStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(ConditionallyAcceptedStatus3Choice.ReasonDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ConditionallyAcceptedStatus3Choice.NoSpecifiedReason),nameof(ConditionallyAcceptedStatus3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ConditionallyAcceptedStatus3Choice.ReasonDetails),nameof(ConditionallyAcceptedStatus3Choice.ReasonDetails))]
    #endif
    [IsoId("_scSIAUHXEeamVPoS58KxXA")]
    [DisplayName("Conditionally Accepted Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConditionallyAcceptedStatus3Choice_
    #else
    public abstract partial class ConditionallyAcceptedStatus3Choice_
    #endif
    {
    }
}
