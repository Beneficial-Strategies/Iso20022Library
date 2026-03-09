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
    [KnownType(typeof(LetterOfGuarantee1Choice.Indicator))]
    [KnownType(typeof(LetterOfGuarantee1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LetterOfGuarantee1Choice.Indicator),nameof(LetterOfGuarantee1Choice.Indicator))]
    [JsonDerivedType(typeof(LetterOfGuarantee1Choice.Proprietary),nameof(LetterOfGuarantee1Choice.Proprietary))]
    #endif
    [IsoId("_QvaoxNp-Ed-ak6NoX_4Aeg_3419755")]
    [DisplayName("Letter Of Guarantee 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LetterOfGuarantee1Choice_
    #else
    public abstract partial class LetterOfGuarantee1Choice_
    #endif
    {
    }
}
