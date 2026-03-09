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
    [KnownType(typeof(Party7Choice.Party))]
    [KnownType(typeof(Party7Choice.Agent))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party7Choice.Party),nameof(Party7Choice.Party))]
    [JsonDerivedType(typeof(Party7Choice.Agent),nameof(Party7Choice.Agent))]
    #endif
    [IsoId("_Pa7iF9p-Ed-ak6NoX_4Aeg_2027182418")]
    [DisplayName("Party 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party7Choice_
    #else
    public abstract partial class Party7Choice_
    #endif
    {
    }
}
