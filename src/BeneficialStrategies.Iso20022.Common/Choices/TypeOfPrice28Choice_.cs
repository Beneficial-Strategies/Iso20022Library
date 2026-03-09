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
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice28Choice.Code))]
    [KnownType(typeof(TypeOfPrice28Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TypeOfPrice28Choice.Code),nameof(TypeOfPrice28Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice28Choice.Proprietary),nameof(TypeOfPrice28Choice.Proprietary))]
    #endif
    [IsoId("_jSvm2znVEeWV5sr121Fc8A")]
    [DisplayName("Type Of Price 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TypeOfPrice28Choice_
    #else
    public abstract partial class TypeOfPrice28Choice_
    #endif
    {
    }
}
