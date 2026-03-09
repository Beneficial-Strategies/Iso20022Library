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
    /// Choice between a short document number, a long document number or a proprietary document number.
    /// </summary>
    [KnownType(typeof(DocumentNumber5Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber5Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber5Choice.ProprietaryNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DocumentNumber5Choice.ShortNumber),nameof(DocumentNumber5Choice.ShortNumber))]
    [JsonDerivedType(typeof(DocumentNumber5Choice.LongNumber),nameof(DocumentNumber5Choice.LongNumber))]
    [JsonDerivedType(typeof(DocumentNumber5Choice.ProprietaryNumber),nameof(DocumentNumber5Choice.ProprietaryNumber))]
    #endif
    [IsoId("_CkuCkTnbEeWLJsP1cO-amg")]
    [DisplayName("Document Number 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DocumentNumber5Choice_
    #else
    public abstract partial class DocumentNumber5Choice_
    #endif
    {
    }
}
