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
    /// Collateral taker&apos;s answer to the collateral giver instruction.
    /// </summary>
    [KnownType(typeof(ResponseStatus9Choice.Code))]
    [KnownType(typeof(ResponseStatus9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ResponseStatus9Choice.Code),nameof(ResponseStatus9Choice.Code))]
    [JsonDerivedType(typeof(ResponseStatus9Choice.Proprietary),nameof(ResponseStatus9Choice.Proprietary))]
    #endif
    [IsoId("_cIPBMLzcEeivTd4NUfCi2g")]
    [DisplayName("Response Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResponseStatus9Choice_
    #else
    public abstract partial class ResponseStatus9Choice_
    #endif
    {
    }
}
