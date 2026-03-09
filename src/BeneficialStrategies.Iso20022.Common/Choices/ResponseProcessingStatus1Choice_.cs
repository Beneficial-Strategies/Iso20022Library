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
    /// Choice between an accepted and a rejected status for the acceptance of a message.
    /// </summary>
    [KnownType(typeof(ResponseProcessingStatus1Choice.Accepted))]
    [KnownType(typeof(ResponseProcessingStatus1Choice.Rejected))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ResponseProcessingStatus1Choice.Accepted),nameof(ResponseProcessingStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(ResponseProcessingStatus1Choice.Rejected),nameof(ResponseProcessingStatus1Choice.Rejected))]
    #endif
    [IsoId("_f9a9gIeUEemJ1cSJJmVYRQ")]
    [DisplayName("Response Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResponseProcessingStatus1Choice_
    #else
    public abstract partial class ResponseProcessingStatus1Choice_
    #endif
    {
    }
}
