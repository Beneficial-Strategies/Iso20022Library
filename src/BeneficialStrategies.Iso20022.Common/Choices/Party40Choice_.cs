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
    [KnownType(typeof(Party40Choice.Party))]
    [KnownType(typeof(Party40Choice.Agent))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party40Choice.Party),nameof(Party40Choice.Party))]
    [JsonDerivedType(typeof(Party40Choice.Agent),nameof(Party40Choice.Agent))]
    #endif
    [IsoId("_8KfE5248EeiU9cctagi5ow")]
    [DisplayName("Party 40 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party40Choice_
    #else
    public abstract partial class Party40Choice_
    #endif
    {
    }
}
