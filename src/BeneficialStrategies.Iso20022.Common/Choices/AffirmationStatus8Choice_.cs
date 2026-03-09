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
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus8Choice.Code))]
    [KnownType(typeof(AffirmationStatus8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AffirmationStatus8Choice.Code),nameof(AffirmationStatus8Choice.Code))]
    [JsonDerivedType(typeof(AffirmationStatus8Choice.Proprietary),nameof(AffirmationStatus8Choice.Proprietary))]
    #endif
    [IsoId("_8H8LUTqpEeWyoP0PbocV1Q")]
    [DisplayName("Affirmation Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AffirmationStatus8Choice_
    #else
    public abstract partial class AffirmationStatus8Choice_
    #endif
    {
    }
}
