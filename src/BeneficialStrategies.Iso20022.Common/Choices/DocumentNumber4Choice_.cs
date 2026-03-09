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
    [KnownType(typeof(DocumentNumber4Choice.ShortNumber))]
    [KnownType(typeof(DocumentNumber4Choice.LongNumber))]
    [KnownType(typeof(DocumentNumber4Choice.ProprietaryNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DocumentNumber4Choice.ShortNumber),nameof(DocumentNumber4Choice.ShortNumber))]
    [JsonDerivedType(typeof(DocumentNumber4Choice.LongNumber),nameof(DocumentNumber4Choice.LongNumber))]
    [JsonDerivedType(typeof(DocumentNumber4Choice.ProprietaryNumber),nameof(DocumentNumber4Choice.ProprietaryNumber))]
    #endif
    [IsoId("_Adb_YNokEeC60axPepSq7g_2005166615")]
    [DisplayName("Document Number 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DocumentNumber4Choice_
    #else
    public abstract partial class DocumentNumber4Choice_
    #endif
    {
    }
}
