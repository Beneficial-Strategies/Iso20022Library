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
    /// Choice of format for the letter of guarantee information.
    /// </summary>
    [KnownType(typeof(LetterOfGuarantee4Choice.Indicator))]
    [KnownType(typeof(LetterOfGuarantee4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LetterOfGuarantee4Choice.Indicator),nameof(LetterOfGuarantee4Choice.Indicator))]
    [JsonDerivedType(typeof(LetterOfGuarantee4Choice.Proprietary),nameof(LetterOfGuarantee4Choice.Proprietary))]
    #endif
    [IsoId("_H0FFUTqJEeWVrPy0StzzSg")]
    [DisplayName("Letter Of Guarantee 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LetterOfGuarantee4Choice_
    #else
    public abstract partial class LetterOfGuarantee4Choice_
    #endif
    {
    }
}
