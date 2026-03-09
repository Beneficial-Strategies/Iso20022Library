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
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party28Choice.Party))]
    [KnownType(typeof(Party28Choice.Agent))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party28Choice.Party),nameof(Party28Choice.Party))]
    [JsonDerivedType(typeof(Party28Choice.Agent),nameof(Party28Choice.Agent))]
    #endif
    [IsoId("_b_UWEdnSEeS--7IJLPC9lw")]
    [DisplayName("Party 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party28Choice_
    #else
    public abstract partial class Party28Choice_
    #endif
    {
    }
}
