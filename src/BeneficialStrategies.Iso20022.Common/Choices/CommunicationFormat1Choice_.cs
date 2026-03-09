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
    /// Specifies a choice of format for statements.
    /// </summary>
    [KnownType(typeof(CommunicationFormat1Choice.Code))]
    [KnownType(typeof(CommunicationFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommunicationFormat1Choice.Code),nameof(CommunicationFormat1Choice.Code))]
    [JsonDerivedType(typeof(CommunicationFormat1Choice.Proprietary),nameof(CommunicationFormat1Choice.Proprietary))]
    #endif
    [IsoId("_1gGtkA1dEeKGXqvMN6jpiw")]
    [DisplayName("Communication Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommunicationFormat1Choice_
    #else
    public abstract partial class CommunicationFormat1Choice_
    #endif
    {
    }
}
