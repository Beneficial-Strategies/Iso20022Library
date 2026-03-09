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
    /// Choice of format for the communication channel method.
    /// </summary>
    [KnownType(typeof(CommunicationMethod1Choice.Code))]
    [KnownType(typeof(CommunicationMethod1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommunicationMethod1Choice.Code),nameof(CommunicationMethod1Choice.Code))]
    [JsonDerivedType(typeof(CommunicationMethod1Choice.Proprietary),nameof(CommunicationMethod1Choice.Proprietary))]
    #endif
    [IsoId("_93Z_w3ltEeG7BsjMvd1mEw_1540700249")]
    [DisplayName("Communication Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommunicationMethod1Choice_
    #else
    public abstract partial class CommunicationMethod1Choice_
    #endif
    {
    }
}
