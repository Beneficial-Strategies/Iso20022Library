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
    /// Choice of formats for a type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice46Choice.Code))]
    [KnownType(typeof(TypeOfPrice46Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TypeOfPrice46Choice.Code),nameof(TypeOfPrice46Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice46Choice.Proprietary),nameof(TypeOfPrice46Choice.Proprietary))]
    #endif
    [IsoId("_pc5UMDhfEeamLZQeccJa7w")]
    [DisplayName("Type Of Price 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TypeOfPrice46Choice_
    #else
    public abstract partial class TypeOfPrice46Choice_
    #endif
    {
    }
}
