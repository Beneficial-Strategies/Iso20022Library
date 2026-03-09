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
    /// Choice of formats for the method of transmission.
    /// </summary>
    [KnownType(typeof(CommunicationMethod3Choice.Code))]
    [KnownType(typeof(CommunicationMethod3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommunicationMethod3Choice.Code),nameof(CommunicationMethod3Choice.Code))]
    [JsonDerivedType(typeof(CommunicationMethod3Choice.Proprietary),nameof(CommunicationMethod3Choice.Proprietary))]
    #endif
    [IsoId("_WBqvcQgqEeSUG-8hqXsVMQ")]
    [DisplayName("Communication Method 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommunicationMethod3Choice_
    #else
    public abstract partial class CommunicationMethod3Choice_
    #endif
    {
    }
}
