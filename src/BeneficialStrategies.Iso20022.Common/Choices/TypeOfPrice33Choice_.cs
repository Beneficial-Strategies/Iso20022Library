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
    [KnownType(typeof(TypeOfPrice33Choice.Code))]
    [KnownType(typeof(TypeOfPrice33Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TypeOfPrice33Choice.Code),nameof(TypeOfPrice33Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice33Choice.Proprietary),nameof(TypeOfPrice33Choice.Proprietary))]
    #endif
    [IsoId("_5W2yu5NLEeWGlc8L7oPDIg")]
    [DisplayName("Type Of Price 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TypeOfPrice33Choice_
    #else
    public abstract partial class TypeOfPrice33Choice_
    #endif
    {
    }
}
