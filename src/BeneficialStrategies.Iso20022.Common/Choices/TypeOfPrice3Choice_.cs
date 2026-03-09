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
    [KnownType(typeof(TypeOfPrice3Choice.Code))]
    [KnownType(typeof(TypeOfPrice3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TypeOfPrice3Choice.Code),nameof(TypeOfPrice3Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice3Choice.Proprietary),nameof(TypeOfPrice3Choice.Proprietary))]
    #endif
    [IsoId("_Qu0y4dp-Ed-ak6NoX_4Aeg_-470141536")]
    [DisplayName("Type Of Price 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TypeOfPrice3Choice_
    #else
    public abstract partial class TypeOfPrice3Choice_
    #endif
    {
    }
}
